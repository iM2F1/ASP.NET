        /// <summary>
        /// Word文件轉PDF文件
        /// </summary>
        /// <param name="source">Word文件位置</param>
        /// <param name="target">PDF文件位置</param>
        /// <returns></returns>
        public static bool Word2Pdf(string source, string target)
        {
            try
            {
                var WordApp = new Microsoft.Office.Interop.Word.Application();
                Microsoft.Office.Interop.Word.Document doc = WordApp.Documents.Open(source);
                doc.SaveAs(target, Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatPDF);
                WordApp.Visible = false;
                doc.Close();
                WordApp.Quit();
                Marshal.ReleaseComObject(doc);
                Marshal.ReleaseComObject(WordApp);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
