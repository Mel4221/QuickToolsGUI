//
// ${Melquiceded Balbi Villanueva}
//
// Author:
//       ${Melquiceded} <${melquiceded.balbi@gmail.com}>
//
// Copyright (c) ${2089} MIT
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.using System;
using System;
using System.IO;



namespace QuickTools.QIO
{
      /// <summary>
      /// Binary.
      /// </summary>
      public partial class Binary
      {



            public static bool IsBigFile(string file)
            {
                  if (!File.Exists(file)) throw new FileNotFoundException(); 

                  try
                  {
                        File.ReadAllBytes(file);
                        return false; 
                  }
                  catch
                  {
                        return true;; 
                  }
            }

            /// <summary>
            /// Copies the binary file.
            /// </summary>
            /// <returns><c>true</c>, if binary file was copyed, <c>false</c> otherwise.</returns>
            /// <param name="srcfilename">Srcfilename.</param>
            /// <param name="destfilename">Destfilename.</param>
            public static bool CopyBinaryFile(string srcfilename, string destfilename)
            {
                  if (!File.Exists(srcfilename))
                  {
                        Console.WriteLine("Could not find the Source file");
                        return false;
                  }
                  Stream input = File.Open(srcfilename, FileMode.Open);
                  FileStream output = File.Open(destfilename, FileMode.Create);
                  BinaryReader binaryReader = new BinaryReader(input);
                  BinaryWriter binaryWriter = new BinaryWriter(output);
                  Binary binary = new Binary(); 
                  while (true)
                  {
                        byte[] buffer = new byte[10240];
                        int num = binaryReader.Read(buffer, 0, 10240);
                        if (num <= 0)
                        {
                              break;
                        }
                        binary.Buffer = buffer;
                        binaryWriter.Write(buffer, 0, num);
                        if (num < 10240)
                        {
                              break;
                        }
                  }
                  binaryReader.Close();
                  binaryWriter.Close();
                  return true;
            }

            /// <summary>
            /// Copies the binary file.
            /// </summary>
            /// <returns><c>true</c>, if binary file was copyed, <c>false</c> otherwise.</returns>
            /// <param name="srcfilename">Srcfilename.</param>
            /// <param name="destfilename">Destfilename.</param>
            /// <param name="Status">Status.</param>
            public static bool CopyBinaryFile(string srcfilename, string destfilename, Action Status)
            {
                  if (!File.Exists(srcfilename))
                  {
                        Console.WriteLine("Could not find the Source file");
                        return false;
                  }
                  new FileInfo(srcfilename);
                  Stream input = File.Open(srcfilename, FileMode.Open);
                  FileStream output = File.Open(destfilename, FileMode.Create);
                  BinaryReader binaryReader = new BinaryReader(input);
                  BinaryWriter binaryWriter = new BinaryWriter(output);
                  while (true)
                  {
                        byte[] buffer = new byte[10240];
                        int num = binaryReader.Read(buffer, 0, 10240);
                        if (num <= 0)
                        {
                              break;
                        }
                        binaryWriter.Write(buffer, 0, num);
                        if (num < 10240)
                        {
                              break;
                        }
                        Status();
                  }
                  binaryReader.Close();
                  binaryWriter.Close();
                  return true;
            }
            /// <summary>
            /// Copies the text file.
            /// </summary>
            /// <returns><c>true</c>, if text file was copyed, <c>false</c> otherwise.</returns>
            /// <param name="srcfilename">Srcfilename.</param>
            /// <param name="destfilename">Destfilename.</param>
            public static bool CopyTextFile(string srcfilename, string destfilename)
            {
                  if (!File.Exists(srcfilename))
                  {
                        Console.WriteLine("Could not find the Source file");
                        return false;
                  }
                  StreamReader streamReader = new StreamReader(srcfilename);
                  StreamWriter streamWriter = new StreamWriter(destfilename);
                  while (true)
                  {
                        char[] buffer = new char[1024];
                        int num = streamReader.Read(buffer, 0, 1024);
                        if (num <= 0)
                        {
                              break;
                        }
                        streamWriter.Write(buffer, 0, num);
                        if (num < 1024)
                        {
                              break;
                        }
                  }
                  streamReader.Close();
                  streamWriter.Close();
                  return true;
            }



           
            /// <summary>
            /// Moves the file.
            /// </summary>
            /// <returns><c>true</c>, if file was moved, <c>false</c> otherwise.</returns>
            /// <param name="pointA">Point a.</param>
            /// <param name="pointB">Point b.</param>
            public static bool MoveFile(string pointA, string pointB)
            {
                  bool wasSucessfull = true;
                  if (!File.Exists(pointA))
                  {
                        throw new FileNotFoundException("The file in point A was not founded: " + pointA);

                  }

                   byte[] a = Binary.Reader(pointA); 

                  Binary.Writer(pointB, a);

                  byte[] b = Binary.Reader(pointB);

                if(!CheckFileIntegrity(a, b))
                  {
                        throw new IOException("The File was moved but it is Curropted");
                  }

                  File.Delete(pointA);

                  return wasSucessfull;
            }


        /// <summary>
        /// Reader the specified file.
        /// </summary>
        /// <returns>The reader.</returns>
        /// <param name="file">File.</param>
        public static byte[] Reader(string file)
        {
               
                        int fileLengh = File.ReadAllBytes(file).Length;
                        byte[] bytes = new byte[fileLengh];
                        using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read))
                        {
                              using (BinaryReader reader = new BinaryReader(fs))
                              {
                                    reader.Read(bytes, 0, fileLengh);
                                    return bytes;
                              }
                        }
        }


            /// <summary>
            /// Checks the file integrity.
            /// </summary>x`
            /// <returns><c>true</c>, if file integrity was checked, <c>false</c> otherwise.</returns>
            /// <param name="a">The alpha component.</param>
            /// <param name="b">The blue component.</param>
            public static bool CheckFileIntegrity(byte[] a, byte[] b)
            {
                  bool isSafe = true;

                  for (int i = 0; i < a.Length; i++)
                  {

                        if (a[i] != b[i])
                        {
                              return false;
                        }
                  }

                  return isSafe;
            }



            /// <summary>
            /// Checks the file integrity.
            /// </summary>
            /// <returns><c>true</c>, if file integrity was checked, <c>false</c> otherwise.</returns>
            /// <param name="fileA">File a.</param>
            /// <param name="fileB">File b.</param>
            public static bool CheckFileIntegrity(string fileA, string fileB)
            {
                  byte[] a = Binary.Reader(fileA);
                  byte[] b = Binary.Reader(fileB);
                  bool isSafe = true;

                  for (int i = 0; i < a.Length; i++)
                  {

                        if (a[i] != b[i])
                        {
                              return false;
                        }
                  }

                  return isSafe;
            }

            /// <summary>
            /// Writer the specified file and bytes.
            /// </summary>
            /// <param name="file">File.</param>
            /// <param name="bytes">Bytes.</param>
            public static void Writer(string file,byte[] bytes)
        {
         //   if (File.Exists(file)) File.Delete(file); 


            using (FileStream fs = new FileStream(file, FileMode.Create, FileAccess.Write))
            {
                using (BinaryWriter writer = new BinaryWriter(fs))
                {

                     writer.Write(bytes, 0, bytes.Length);

                }
            }
        }


           
      }

}
