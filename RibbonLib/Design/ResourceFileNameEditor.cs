﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RibbonLib.Design
{
    public class ResourceFileNameEditor : System.Windows.Forms.Design.FileNameEditor
    {

        protected override void InitializeDialog(OpenFileDialog openFileDialog)
        {
            base.InitializeDialog(openFileDialog);
            openFileDialog.DefaultExt = "*.ribbon";
            openFileDialog.Filter = "Ribbon resource definition|*.ribbon";
        }
        
    }
}
