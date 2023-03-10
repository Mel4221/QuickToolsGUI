/*
    Documentation at : 
    https://learn.microsoft.com/en-us/dotnet/api/system.io.binarywriter.write?view=net-6.0#system-io-binarywriter-write(system-byte()-system-int32-system-int32)   
    https://learn.microsoft.com/en-us/dotnet/api/system.io.binaryreader.read?view=net-6.0#system-io-binaryreader-read(system-byte()-system-int32-system-int32)
*/

using System;
using System.IO;
using System.Text;

namespace QuickTools.QIO
{


      /// <summary>
      /// Dumps the Files data 
      /// </summary>
      public class FileDummper
      {
            /// <summary>
            /// The size of the chunk.
            /// </summary>
            public static readonly int CHUNK_SIZE = 1024;

            /// <summary>
            /// Dump the specified args.
            /// </summary>
            /// <param name="args">Arguments.</param>
            public static void Dump(String[] args)
            {
                  if ((args.Length == 0) || !File.Exists(args[0]))
                  {
                        Console.WriteLine("Please provide an existing file name.");
                  }
                  else
                  {
                        using (FileStream fs = new FileStream(args[0], FileMode.Open, FileAccess.Read))
                        {
                              using (BinaryReader br = new BinaryReader(fs, new ASCIIEncoding()))
                              {
                                    byte[] chunk;

                                    chunk = br.ReadBytes(CHUNK_SIZE);
                                    while (chunk.Length > 0)
                                    {
                                          //DumpBytes(chunk, chunk.Length);
                                          chunk = br.ReadBytes(CHUNK_SIZE);

                                          //Get.Wait(chunk.Length); 
                                    }

                                    // Get.Yellow(chunk.Length);
                              }
                        }
                  }
            }

            /// <summary>
            /// Dumps the bytes.
            /// </summary>
            /// <param name="bdata">Bdata.</param>
            /// <param name="len">Length.</param>
            public static void DumpBytes(byte[] bdata, int len)
            {

                  int i;
                  int j = 0;
                  char dchar;
                  // 3 * 16 chars for hex display, 16 chars for text and 8 chars
                  // for the 'gutter' int the middle.
                  StringBuilder dumptext = new StringBuilder("        ", 16 * 4 + 8);
                  for (i = 0; i < len; i++)
                  {
                        dumptext.Insert(j * 3, String.Format("{0:X2} ", (int)bdata[i]));
                        dchar = (char)bdata[i];
                        //' replace 'non-printable' chars with a '.'.
                        if (Char.IsWhiteSpace(dchar) || Char.IsControl(dchar))
                        {
                              dchar = '.';
                        }
                        dumptext.Append(dchar);
                        j++;
                        if (j == 16)
                        {
                              Console.WriteLine(dumptext);
                              dumptext.Length = 0;
                              dumptext.Append("        ");
                              j = 0;
                        }

                        //   Get.Wait(); 
                  }
                  // display the remaining line
                  if (j > 0)
                  {
                        for (i = j; i < 16; i++)
                        {
                              dumptext.Insert(j * 3, "   ");
                        }
                        Console.WriteLine(dumptext);
                  }
            }
      }
}