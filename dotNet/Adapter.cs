using Atomus.Diagnostics;
using System;
using System.Windows.Forms;

namespace Atomus.Control.MessageBox
{
    public class Adapter : IMessageBox
    {
        private static IMessageBox messageBox;
        
        public Adapter()
        {
            if (messageBox == null)
            {
                try
                {
                    messageBox = (IMessageBox)this.CreateInstance("MessageBox");
                }
                catch (AtomusException exception)
                {
                    DiagnosticsTool.MyTrace(exception);
                    messageBox = new WinMessageBox();
                }
                catch (Exception exception)
                {
                    DiagnosticsTool.MyTrace(exception);
                    messageBox = new WinMessageBox();
                }
            }
        }

        DialogResult IMessageBox.Show(string text, params string[] args)
        {
            return (messageBox != null) ? messageBox.Show(text, args) :
                        System.Windows.Forms.MessageBox.Show(text.Translate(args));
        }
        DialogResult IMessageBox.Show(string text, string caption, params string[] args)
        {
            return (messageBox != null) ? messageBox.Show(text, caption, args) :
                        System.Windows.Forms.MessageBox.Show(text.Translate(args), caption.Translate());
        }
        DialogResult IMessageBox.Show(string text, string caption, MessageBoxButtons messageBoxButtons, params string[] args)
        {
            return (messageBox != null) ? messageBox.Show(text, caption, messageBoxButtons, args) :
                        System.Windows.Forms.MessageBox.Show(text.Translate(args), caption.Translate(), messageBoxButtons);
        }
        DialogResult IMessageBox.Show(string text, string caption, MessageBoxButtons messageBoxButtons, MessageBoxIcon messageBoxIcon, params string[] args)
        {
            return (messageBox != null) ? messageBox.Show(text, caption, messageBoxButtons, messageBoxIcon, args) :
                        System.Windows.Forms.MessageBox.Show(text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon);
        }
        DialogResult IMessageBox.Show(string text, string caption, MessageBoxButtons messageBoxButtons, MessageBoxIcon messageBoxIcon, MessageBoxDefaultButton messageBoxDefaultButton, params string[] args)
        {
            return (messageBox != null) ? messageBox.Show(text, caption, messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, args) :
                        System.Windows.Forms.MessageBox.Show(text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton);
        }
        DialogResult IMessageBox.Show(string text, string caption, MessageBoxButtons messageBoxButtons, MessageBoxIcon messageBoxIcon, MessageBoxDefaultButton messageBoxDefaultButton, MessageBoxOptions messageBoxOptions, params string[] args)
        {
            return (messageBox != null) ? messageBox.Show(text, caption, messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions, args) :
                        System.Windows.Forms.MessageBox.Show(text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions);
        }
        DialogResult IMessageBox.Show(string text, string caption, MessageBoxButtons messageBoxButtons, MessageBoxIcon messageBoxIcon, MessageBoxDefaultButton messageBoxDefaultButton, MessageBoxOptions messageBoxOptions, bool displayHelpButton, params string[] args)
        {
            return (messageBox != null) ? messageBox.Show(text, caption, messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions, displayHelpButton, args) :
                        System.Windows.Forms.MessageBox.Show(text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions, displayHelpButton);
        }
        DialogResult IMessageBox.Show(string text, string caption, MessageBoxButtons messageBoxButtons, MessageBoxIcon messageBoxIcon, MessageBoxDefaultButton messageBoxDefaultButton, MessageBoxOptions messageBoxOptions, string helpFilePath, params string[] args)
        {
            return (messageBox != null) ? messageBox.Show(text, caption, messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions, helpFilePath, args) :
                        System.Windows.Forms.MessageBox.Show(text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions, helpFilePath);
        }
        DialogResult IMessageBox.Show(string text, string caption, MessageBoxButtons messageBoxButtons, MessageBoxIcon messageBoxIcon, MessageBoxDefaultButton messageBoxDefaultButton, MessageBoxOptions messageBoxOptions, string helpFilePath, string keyword, params string[] args)
        {
            return (messageBox != null) ? messageBox.Show(text, caption, messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions, helpFilePath, keyword, args) :
                        System.Windows.Forms.MessageBox.Show(text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions, helpFilePath, keyword);
        }
        DialogResult IMessageBox.Show(string text, string caption, MessageBoxButtons messageBoxButtons, MessageBoxIcon messageBoxIcon, MessageBoxDefaultButton messageBoxDefaultButton, MessageBoxOptions messageBoxOptions, string helpFilePath, HelpNavigator helpNavigator, params string[] args)
        {
            return (messageBox != null) ? messageBox.Show(text, caption, messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions, helpFilePath, helpNavigator, args) :
                        System.Windows.Forms.MessageBox.Show(text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions, helpFilePath, helpNavigator);
        }
        DialogResult IMessageBox.Show(string text, string caption, MessageBoxButtons messageBoxButtons, MessageBoxIcon messageBoxIcon, MessageBoxDefaultButton messageBoxDefaultButton, MessageBoxOptions messageBoxOptions, string helpFilePath, HelpNavigator helpNavigator, object parameter, params string[] args)
        {
            return (messageBox != null) ? messageBox.Show(text, caption, messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions, helpFilePath, helpNavigator, parameter, args) :
                        System.Windows.Forms.MessageBox.Show(text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions, helpFilePath, helpNavigator, parameter);
        }
        DialogResult IMessageBox.Show(AtomusException exception)
        {
            return (messageBox != null) ? messageBox.Show(exception) :
                System.Windows.Forms.MessageBox.Show(exception.Message, exception.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        DialogResult IMessageBox.Show(Exception exception)
        {
            if (messageBox != null)
                return messageBox.Show(exception);
            else
            {
                if (exception.InnerException != null)
                    return System.Windows.Forms.MessageBox.Show(exception.InnerException.Message, exception.InnerException.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    return System.Windows.Forms.MessageBox.Show(exception.Message, exception.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        DialogResult IMessageBox.Show(IWin32Window _Owner, string text, params string[] args)
        {
            return (messageBox != null) ? messageBox.Show(_Owner, text, args) :
                        System.Windows.Forms.MessageBox.Show(_Owner, text.Translate(args));
        }
        DialogResult IMessageBox.Show(IWin32Window _Owner, string text, string caption, params string[] args)
        {
            return (messageBox != null) ? messageBox.Show(_Owner, text, caption, args) :
                        System.Windows.Forms.MessageBox.Show(_Owner, text.Translate(args), caption.Translate());
        }
        DialogResult IMessageBox.Show(IWin32Window _Owner, string text, string caption, MessageBoxButtons messageBoxButtons, params string[] args)
        {
            return (messageBox != null) ? messageBox.Show(_Owner, text, caption, messageBoxButtons, args) :
                        System.Windows.Forms.MessageBox.Show(_Owner, text.Translate(args), caption.Translate(), messageBoxButtons);
        }
        DialogResult IMessageBox.Show(IWin32Window _Owner, string text, string caption, MessageBoxButtons messageBoxButtons, MessageBoxIcon messageBoxIcon, params string[] args)
        {
            return (messageBox != null) ? messageBox.Show(_Owner, text, caption, messageBoxButtons, messageBoxIcon, args) :
                        System.Windows.Forms.MessageBox.Show(_Owner, text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon);
        }
        DialogResult IMessageBox.Show(IWin32Window _Owner, string text, string caption, MessageBoxButtons messageBoxButtons, MessageBoxIcon messageBoxIcon, MessageBoxDefaultButton messageBoxDefaultButton, params string[] args)
        {
            return (messageBox != null) ? messageBox.Show(_Owner, text, caption, messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, args) :
                        System.Windows.Forms.MessageBox.Show(_Owner, text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton);
        }
        DialogResult IMessageBox.Show(IWin32Window _Owner, string text, string caption, MessageBoxButtons messageBoxButtons, MessageBoxIcon messageBoxIcon, MessageBoxDefaultButton messageBoxDefaultButton, MessageBoxOptions messageBoxOptions, params string[] args)
        {
            return (messageBox != null) ? messageBox.Show(_Owner, text, caption, messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions, args) :
                        System.Windows.Forms.MessageBox.Show(_Owner, text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions);
        }
        DialogResult IMessageBox.Show(IWin32Window _Owner, string text, string caption, MessageBoxButtons messageBoxButtons, MessageBoxIcon messageBoxIcon, MessageBoxDefaultButton messageBoxDefaultButton, MessageBoxOptions messageBoxOptions, string helpFilePath, params string[] args)
        {
            return (messageBox != null) ? messageBox.Show(_Owner, text, caption, messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions, helpFilePath, args) :
                        System.Windows.Forms.MessageBox.Show(_Owner, text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions, helpFilePath);
        }
        DialogResult IMessageBox.Show(IWin32Window _Owner, string text, string caption, MessageBoxButtons messageBoxButtons, MessageBoxIcon messageBoxIcon, MessageBoxDefaultButton messageBoxDefaultButton, MessageBoxOptions messageBoxOptions, string helpFilePath, string keyword, params string[] args)
        {
            return (messageBox != null) ? messageBox.Show(_Owner, text, caption, messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions, helpFilePath, keyword, args) :
                        System.Windows.Forms.MessageBox.Show(_Owner, text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions, helpFilePath, keyword);
        }
        DialogResult IMessageBox.Show(IWin32Window _Owner, string text, string caption, MessageBoxButtons messageBoxButtons, MessageBoxIcon messageBoxIcon, MessageBoxDefaultButton messageBoxDefaultButton, MessageBoxOptions messageBoxOptions, string helpFilePath, HelpNavigator helpNavigator, params string[] args)
        {
            return (messageBox != null) ? messageBox.Show(_Owner, text, caption, messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions, helpFilePath, helpNavigator, args) :
                        System.Windows.Forms.MessageBox.Show(_Owner, text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions, helpFilePath, helpNavigator);
        }
        DialogResult IMessageBox.Show(IWin32Window _Owner, string text, string caption, MessageBoxButtons messageBoxButtons, MessageBoxIcon messageBoxIcon, MessageBoxDefaultButton messageBoxDefaultButton, MessageBoxOptions messageBoxOptions, string helpFilePath, HelpNavigator helpNavigator, object parameter, params string[] args)
        {
            return (messageBox != null) ? messageBox.Show(_Owner, text, caption, messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions, helpFilePath, helpNavigator, parameter, args) :
                        System.Windows.Forms.MessageBox.Show(_Owner, text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions, helpFilePath, helpNavigator, parameter);
        }
        DialogResult IMessageBox.Show(IWin32Window _Owner, AtomusException exception)
        {
            return (messageBox != null) ? messageBox.Show(exception) :
                System.Windows.Forms.MessageBox.Show(_Owner, exception.Message, exception.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        DialogResult IMessageBox.Show(IWin32Window _Owner, Exception exception)
        {
            if (messageBox != null)
                return messageBox.Show(_Owner, exception);
            else
            {
                if (exception.InnerException != null)
                    return System.Windows.Forms.MessageBox.Show(_Owner, exception.InnerException.Message, exception.InnerException.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    return System.Windows.Forms.MessageBox.Show(_Owner, exception.Message, exception.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}