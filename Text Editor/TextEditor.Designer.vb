<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTextEditor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mnuToolStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.mnuOpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.txtTextField = New System.Windows.Forms.RichTextBox()
        Me.mnuToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuToolStrip
        '
        Me.mnuToolStrip.BackColor = System.Drawing.SystemColors.MenuBar
        Me.mnuToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuHelp})
        Me.mnuToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuToolStrip.Name = "mnuToolStrip"
        Me.mnuToolStrip.Size = New System.Drawing.Size(892, 28)
        Me.mnuToolStrip.TabIndex = 0
        Me.mnuToolStrip.Text = "Menu"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNew, Me.mnuOpen, Me.mnuSave, Me.mnuSaveAs, Me.mnuClose, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(46, 24)
        Me.mnuFile.Text = "&File"
        '
        'mnuNew
        '
        Me.mnuNew.Name = "mnuNew"
        Me.mnuNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuNew.Size = New System.Drawing.Size(181, 26)
        Me.mnuNew.Text = "&New"
        Me.mnuNew.ToolTipText = "Create a new text file." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'mnuOpen
        '
        Me.mnuOpen.Name = "mnuOpen"
        Me.mnuOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuOpen.Size = New System.Drawing.Size(181, 26)
        Me.mnuOpen.Text = "&Open"
        Me.mnuOpen.ToolTipText = "Open an existing text file."
        '
        'mnuSave
        '
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSave.Size = New System.Drawing.Size(181, 26)
        Me.mnuSave.Text = "&Save"
        Me.mnuSave.ToolTipText = "Save the current text file under its current file name."
        '
        'mnuSaveAs
        '
        Me.mnuSaveAs.Name = "mnuSaveAs"
        Me.mnuSaveAs.Size = New System.Drawing.Size(181, 26)
        Me.mnuSaveAs.Text = "Save &As"
        Me.mnuSaveAs.ToolTipText = "Save the current text under new file name."
        '
        'mnuClose
        '
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.Size = New System.Drawing.Size(181, 26)
        Me.mnuClose.Text = "C&lose"
        Me.mnuClose.ToolTipText = "Closes the current text file."
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(181, 26)
        Me.mnuExit.Text = "E&xit"
        Me.mnuExit.ToolTipText = "Exits the program."
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCopy, Me.mnuCut, Me.mnuPaste})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(49, 24)
        Me.mnuEdit.Text = "&Edit"
        '
        'mnuCopy
        '
        Me.mnuCopy.Name = "mnuCopy"
        Me.mnuCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuCopy.Size = New System.Drawing.Size(177, 26)
        Me.mnuCopy.Text = "&Copy"
        Me.mnuCopy.ToolTipText = "Copy the selected text to clipboard."
        '
        'mnuCut
        '
        Me.mnuCut.Name = "mnuCut"
        Me.mnuCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuCut.Size = New System.Drawing.Size(177, 26)
        Me.mnuCut.Text = "Cu&t"
        Me.mnuCut.ToolTipText = "Cut the selected text to clipboard."
        '
        'mnuPaste
        '
        Me.mnuPaste.Name = "mnuPaste"
        Me.mnuPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mnuPaste.Size = New System.Drawing.Size(177, 26)
        Me.mnuPaste.Text = "&Paste"
        Me.mnuPaste.ToolTipText = "Paste the text in current clipboard."
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(55, 24)
        Me.mnuHelp.Text = "&Help"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(133, 26)
        Me.mnuAbout.Text = "A&bout"
        '
        'mnuSaveFileDialog
        '
        Me.mnuSaveFileDialog.DefaultExt = "txt"
        Me.mnuSaveFileDialog.Title = "Save"
        '
        'mnuOpenFileDialog
        '
        Me.mnuOpenFileDialog.DefaultExt = "txt"
        Me.mnuOpenFileDialog.FileName = "OpenFileDialog"
        Me.mnuOpenFileDialog.Title = "Open"
        '
        'txtTextField
        '
        Me.txtTextField.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTextField.Location = New System.Drawing.Point(0, 28)
        Me.txtTextField.Name = "txtTextField"
        Me.txtTextField.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.txtTextField.Size = New System.Drawing.Size(892, 451)
        Me.txtTextField.TabIndex = 1
        Me.txtTextField.Text = ""
        '
        'frmTextEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(892, 479)
        Me.Controls.Add(Me.txtTextField)
        Me.Controls.Add(Me.mnuToolStrip)
        Me.MainMenuStrip = Me.mnuToolStrip
        Me.Name = "frmTextEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Text Editor"
        Me.mnuToolStrip.ResumeLayout(False)
        Me.mnuToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuToolStrip As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuEdit As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuCopy As ToolStripMenuItem
    Friend WithEvents mnuAbout As ToolStripMenuItem
    Friend WithEvents mnuCut As ToolStripMenuItem
    Friend WithEvents mnuNew As ToolStripMenuItem
    Friend WithEvents mnuOpen As ToolStripMenuItem
    Friend WithEvents mnuSave As ToolStripMenuItem
    Friend WithEvents mnuSaveAs As ToolStripMenuItem
    Friend WithEvents mnuClose As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuPaste As ToolStripMenuItem
    Friend WithEvents mnuSaveFileDialog As SaveFileDialog
    Friend WithEvents mnuOpenFileDialog As OpenFileDialog
    Friend WithEvents txtTextField As RichTextBox
End Class
