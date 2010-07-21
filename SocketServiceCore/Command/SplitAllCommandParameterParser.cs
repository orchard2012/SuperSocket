﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperSocket.SocketServiceCore.Command
{
    public class SplitAllCommandParameterParser : ICommandParameterParser
    {
        private string m_Spliter;

        public SplitAllCommandParameterParser() : this(" ")
        {

        }

        public SplitAllCommandParameterParser(string spliter)
        {
            m_Spliter = spliter;
        }

        #region ICommandParameterParser Members

        public string[] ParseCommandParameter(CommandInfo command)
        {
            return command.Param.Split(new string[] { m_Spliter }, StringSplitOptions.RemoveEmptyEntries);
        }

        #endregion
    }
}