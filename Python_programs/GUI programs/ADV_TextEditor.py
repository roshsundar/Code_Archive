#on tut 2 6:10

import wx
import wx.lib.dialogs
import wx.stc as stc

faces={
    'times':'Times New Roman',
    'mono':'Courier New',
    'helv':'Arial',
    'other':'Comic Sana MS',
    'size':10,
    'size2':8,
}

class MainWindow(wx.frame):
    def __init__(self, parent, title):
        self.leftMarginWidth=25

        wx.frame.__init__(self, parent, title=title, size=(800,600))
        self.control stc.StyledTextCtrl(self, style=wx.TE_MULTILINE | wx.TE_WORDWRAP)

        self.Show()

frame=MainWindow(None, "My text editor")
app.Mainloop()
