﻿using System.Configuration;
        private HttpListener listener;

        public HttpServer() {
            listener = new HttpListener();
        }

            var url = "";
            listener.Prefixes.Add(url);
#if DEBUG
            listener.Prefixes.Add(url);
#endif
            Console.WriteLine("开始监听:" + url);
            //StartListener();