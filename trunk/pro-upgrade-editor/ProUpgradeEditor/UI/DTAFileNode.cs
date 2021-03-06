using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Reflection;
using System.Windows.Forms;
using Sanford.Multimedia;
using Sanford.Multimedia.Midi;
using ProUpgradeEditor.Common;
using System.Threading;
using System.Globalization;
using XPackage;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Linq.Expressions;
using X360;


namespace ProUpgradeEditor.UI
{
    public class DTAFileNode
    {
        public string Name;
        public string Value;

        public IEnumerable<DTAFileNode> Children;

        public DTAFileNode(string name, string value)
        {
            Name = name;
            Value = value;
        }
    }
}