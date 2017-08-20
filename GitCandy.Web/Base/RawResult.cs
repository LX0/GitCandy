﻿using System;
using System.Net.Mime;
using System.Web.Mvc;

namespace GitCandy.Base
{
    public class RawResult : ActionResult
    {
        public RawResult(Byte[] contents, String contentType = "text/plain", String fileDownloadName = null)
        {
            if (contents == null)
                throw new ArgumentNullException("contents");

            Contents = contents;
            ContentType = contentType;
            FileDownloadName = fileDownloadName;
        }

        public Byte[] Contents { get; private set; }
        public String ContentType { get; private set; }
        public String FileDownloadName { get; private set; }

        public override void ExecuteResult(ControllerContext context)
        {
            if (context == null)
                throw new ArgumentNullException("context");

            var response = context.HttpContext.Response;
            if (!String.IsNullOrEmpty(FileDownloadName))
                response.AddHeader("Content-Disposition", new ContentDisposition { FileName = FileDownloadName }.ToString());
            response.ContentType = ContentType;
            response.BinaryWrite(Contents);
        }
    }
}