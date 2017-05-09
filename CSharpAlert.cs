        /// <summary>
        /// 錯誤訊息視窗，Debug用
        /// </summary>
        /// <param name="msg"></param>
        public void MsgBox(string msg)
        {
            Response.Write("<Script language='Javascript'>");
            Response.Write("alert('" + msg + "')");
            Response.Write("</" + "Script>");
        }
