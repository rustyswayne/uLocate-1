﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uLocate
{
    public class StatusMessage
    {
        public bool Success { get; set; }

        public string Message { get; set; }

        public string Code { get; set; }

        public string ObjectName { get; set; }

        public bool HasMessage {
            get
            {
                if (Message != string.Empty & Message != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public StatusMessage()
        {
        }

        public StatusMessage(bool WasSuccessful)
        {
            this.Success = WasSuccessful;
        }

        public StatusMessage(bool WasSuccessful, string Msg)
        {
            this.Success = WasSuccessful;
            this.Message = Msg;
        }

    }
}