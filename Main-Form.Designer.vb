<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.chlb = New System.Windows.Forms.CheckedListBox
        Me.ctxMenuFileSelect = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ctxDelete = New System.Windows.Forms.ToolStripMenuItem
        Me.ctxDeleteConfirm = New System.Windows.Forms.ToolStripMenuItem
        Me.ctxDeleteConfirmed = New System.Windows.Forms.ToolStripMenuItem
        Me.ctxSeperator1AttrDel = New System.Windows.Forms.ToolStripSeparator
        Me.ctxAttributes = New System.Windows.Forms.ToolStripMenuItem
        Me.ctxReadOnly = New System.Windows.Forms.ToolStripMenuItem
        Me.ctxMakeReadOnly = New System.Windows.Forms.ToolStripMenuItem
        Me.ctxNoReadOnly = New System.Windows.Forms.ToolStripMenuItem
        Me.ctxHidden = New System.Windows.Forms.ToolStripMenuItem
        Me.ctxMakeHidden = New System.Windows.Forms.ToolStripMenuItem
        Me.ctxNoHidden = New System.Windows.Forms.ToolStripMenuItem
        Me.ctxArchive = New System.Windows.Forms.ToolStripMenuItem
        Me.ctxMakeArchive = New System.Windows.Forms.ToolStripMenuItem
        Me.ctxNoArchive = New System.Windows.Forms.ToolStripMenuItem
        Me.ctxSystem = New System.Windows.Forms.ToolStripMenuItem
        Me.ctxMakeSystem = New System.Windows.Forms.ToolStripMenuItem
        Me.ctxNoSystem = New System.Windows.Forms.ToolStripMenuItem
        Me.imgBtnChangeSelection = New System.Windows.Forms.ImageList(Me.components)
        Me.fbd = New System.Windows.Forms.FolderBrowserDialog
        Me.txtPath = New System.Windows.Forms.TextBox
        Me.grpPath = New System.Windows.Forms.GroupBox
        Me.btnQuickPathCancel = New System.Windows.Forms.Button
        Me.imgQuickPath = New System.Windows.Forms.ImageList(Me.components)
        Me.btnQuickPathAct = New System.Windows.Forms.Button
        Me.txtQuickPath = New System.Windows.Forms.TextBox
        Me.t = New System.Windows.Forms.Timer(Me.components)
        Me.grpActions = New System.Windows.Forms.GroupBox
        Me.lblBlankRemoveRight = New System.Windows.Forms.Label
        Me.imgChanges = New System.Windows.Forms.ImageList(Me.components)
        Me.lblReplacedReplaceRight = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblRemovedTo = New System.Windows.Forms.Label
        Me.lblReplaceTo = New System.Windows.Forms.Label
        Me.lblAppendAdd = New System.Windows.Forms.Label
        Me.lblAppendOriginal = New System.Windows.Forms.Label
        Me.lblPrependAdd = New System.Windows.Forms.Label
        Me.lblPrependOriginal = New System.Windows.Forms.Label
        Me.lblOrignalReplaceLeft = New System.Windows.Forms.Label
        Me.lblPrepend = New System.Windows.Forms.Label
        Me.lblAppend = New System.Windows.Forms.Label
        Me.rbRemove = New System.Windows.Forms.RadioButton
        Me.rbReplace = New System.Windows.Forms.RadioButton
        Me.lblW = New System.Windows.Forms.Label
        Me.txtAppend = New System.Windows.Forms.TextBox
        Me.txtReplacedWith = New System.Windows.Forms.TextBox
        Me.txtPrepend = New System.Windows.Forms.TextBox
        Me.txtReplace = New System.Windows.Forms.TextBox
        Me.btnNone = New System.Windows.Forms.Button
        Me.btnInvert = New System.Windows.Forms.Button
        Me.btnAll = New System.Windows.Forms.Button
        Me.btnAct = New System.Windows.Forms.Button
        Me.imgBtnActs = New System.Windows.Forms.ImageList(Me.components)
        Me.btnDir = New System.Windows.Forms.Button
        Me.ctxMenuFileSelect.SuspendLayout()
        Me.grpPath.SuspendLayout()
        Me.grpActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'chlb
        '
        Me.chlb.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chlb.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.chlb.ContextMenuStrip = Me.ctxMenuFileSelect
        Me.chlb.Enabled = False
        Me.chlb.FormattingEnabled = True
        Me.chlb.HorizontalScrollbar = True
        Me.chlb.Items.AddRange(New Object() {"Select a directory first!!!", "Then select the options!!!"})
        Me.chlb.Location = New System.Drawing.Point(12, 12)
        Me.chlb.Margin = New System.Windows.Forms.Padding(5)
        Me.chlb.Name = "chlb"
        Me.chlb.Size = New System.Drawing.Size(283, 487)
        Me.chlb.Sorted = True
        Me.chlb.TabIndex = 0
        '
        'ctxMenuFileSelect
        '
        Me.ctxMenuFileSelect.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ctxDelete, Me.ctxSeperator1AttrDel, Me.ctxAttributes})
        Me.ctxMenuFileSelect.Name = "ctxMenuFileSelect"
        Me.ctxMenuFileSelect.Size = New System.Drawing.Size(123, 54)
        '
        'ctxDelete
        '
        Me.ctxDelete.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ctxDeleteConfirm})
        Me.ctxDelete.Image = Global.MassRename.My.Resources.Resources.ctxdelete
        Me.ctxDelete.Name = "ctxDelete"
        Me.ctxDelete.Size = New System.Drawing.Size(122, 22)
        Me.ctxDelete.Text = "Delete"
        '
        'ctxDeleteConfirm
        '
        Me.ctxDeleteConfirm.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ctxDeleteConfirmed})
        Me.ctxDeleteConfirm.Image = Global.MassRename.My.Resources.Resources.ctxdeleteconfirm
        Me.ctxDeleteConfirm.Name = "ctxDeleteConfirm"
        Me.ctxDeleteConfirm.Size = New System.Drawing.Size(111, 22)
        Me.ctxDeleteConfirm.Text = "Confirm"
        '
        'ctxDeleteConfirmed
        '
        Me.ctxDeleteConfirmed.Image = Global.MassRename.My.Resources.Resources.ctxyes
        Me.ctxDeleteConfirmed.Name = "ctxDeleteConfirmed"
        Me.ctxDeleteConfirmed.Size = New System.Drawing.Size(91, 22)
        Me.ctxDeleteConfirmed.Text = "Yes"
        '
        'ctxSeperator1AttrDel
        '
        Me.ctxSeperator1AttrDel.Name = "ctxSeperator1AttrDel"
        Me.ctxSeperator1AttrDel.Size = New System.Drawing.Size(119, 6)
        '
        'ctxAttributes
        '
        Me.ctxAttributes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ctxReadOnly, Me.ctxHidden, Me.ctxArchive, Me.ctxSystem})
        Me.ctxAttributes.Image = Global.MassRename.My.Resources.Resources.ctxattributes
        Me.ctxAttributes.Name = "ctxAttributes"
        Me.ctxAttributes.Size = New System.Drawing.Size(122, 22)
        Me.ctxAttributes.Text = "Attributes"
        '
        'ctxReadOnly
        '
        Me.ctxReadOnly.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ctxMakeReadOnly, Me.ctxNoReadOnly})
        Me.ctxReadOnly.Image = Global.MassRename.My.Resources.Resources.ctxno
        Me.ctxReadOnly.Name = "ctxReadOnly"
        Me.ctxReadOnly.Size = New System.Drawing.Size(125, 22)
        Me.ctxReadOnly.Text = "Read-Only"
        '
        'ctxMakeReadOnly
        '
        Me.ctxMakeReadOnly.Image = Global.MassRename.My.Resources.Resources.ctxreadonly
        Me.ctxMakeReadOnly.Name = "ctxMakeReadOnly"
        Me.ctxMakeReadOnly.Size = New System.Drawing.Size(167, 22)
        Me.ctxMakeReadOnly.Text = "Make Read-Only"
        '
        'ctxNoReadOnly
        '
        Me.ctxNoReadOnly.Image = Global.MassRename.My.Resources.Resources.ctxnotreadonly
        Me.ctxNoReadOnly.Name = "ctxNoReadOnly"
        Me.ctxNoReadOnly.Size = New System.Drawing.Size(167, 22)
        Me.ctxNoReadOnly.Text = "Remove Read-Only"
        '
        'ctxHidden
        '
        Me.ctxHidden.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ctxMakeHidden, Me.ctxNoHidden})
        Me.ctxHidden.Image = Global.MassRename.My.Resources.Resources.ctxno
        Me.ctxHidden.Name = "ctxHidden"
        Me.ctxHidden.Size = New System.Drawing.Size(125, 22)
        Me.ctxHidden.Text = "Hidden"
        '
        'ctxMakeHidden
        '
        Me.ctxMakeHidden.Image = Global.MassRename.My.Resources.Resources.ctxhidden
        Me.ctxMakeHidden.Name = "ctxMakeHidden"
        Me.ctxMakeHidden.Size = New System.Drawing.Size(149, 22)
        Me.ctxMakeHidden.Text = "Make Hidden"
        '
        'ctxNoHidden
        '
        Me.ctxNoHidden.Image = Global.MassRename.My.Resources.Resources.ctxnormal
        Me.ctxNoHidden.Name = "ctxNoHidden"
        Me.ctxNoHidden.Size = New System.Drawing.Size(149, 22)
        Me.ctxNoHidden.Text = "Remove Hidden"
        '
        'ctxArchive
        '
        Me.ctxArchive.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ctxMakeArchive, Me.ctxNoArchive})
        Me.ctxArchive.Image = Global.MassRename.My.Resources.Resources.ctxyes
        Me.ctxArchive.Name = "ctxArchive"
        Me.ctxArchive.Size = New System.Drawing.Size(125, 22)
        Me.ctxArchive.Text = "Archive"
        '
        'ctxMakeArchive
        '
        Me.ctxMakeArchive.Image = Global.MassRename.My.Resources.Resources.ctxarchive
        Me.ctxMakeArchive.Name = "ctxMakeArchive"
        Me.ctxMakeArchive.Size = New System.Drawing.Size(152, 22)
        Me.ctxMakeArchive.Text = "Make Archive"
        '
        'ctxNoArchive
        '
        Me.ctxNoArchive.Image = Global.MassRename.My.Resources.Resources.ctxnotarchived
        Me.ctxNoArchive.Name = "ctxNoArchive"
        Me.ctxNoArchive.Size = New System.Drawing.Size(152, 22)
        Me.ctxNoArchive.Text = "Remove Archive"
        '
        'ctxSystem
        '
        Me.ctxSystem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ctxMakeSystem, Me.ctxNoSystem})
        Me.ctxSystem.Image = Global.MassRename.My.Resources.Resources.ctxno
        Me.ctxSystem.Name = "ctxSystem"
        Me.ctxSystem.Size = New System.Drawing.Size(125, 22)
        Me.ctxSystem.Text = "System"
        '
        'ctxMakeSystem
        '
        Me.ctxMakeSystem.Image = Global.MassRename.My.Resources.Resources.ctxsystem
        Me.ctxMakeSystem.Name = "ctxMakeSystem"
        Me.ctxMakeSystem.Size = New System.Drawing.Size(151, 22)
        Me.ctxMakeSystem.Text = "Make System"
        '
        'ctxNoSystem
        '
        Me.ctxNoSystem.Image = Global.MassRename.My.Resources.Resources.ctxnormal
        Me.ctxNoSystem.Name = "ctxNoSystem"
        Me.ctxNoSystem.Size = New System.Drawing.Size(151, 22)
        Me.ctxNoSystem.Text = "Remove System"
        '
        'imgBtnChangeSelection
        '
        Me.imgBtnChangeSelection.ImageStream = CType(resources.GetObject("imgBtnChangeSelection.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgBtnChangeSelection.TransparentColor = System.Drawing.Color.Transparent
        Me.imgBtnChangeSelection.Images.SetKeyName(0, "select-all.png")
        Me.imgBtnChangeSelection.Images.SetKeyName(1, "select-invert.png")
        Me.imgBtnChangeSelection.Images.SetKeyName(2, "select-none.png")
        '
        'fbd
        '
        Me.fbd.ShowNewFolderButton = False
        '
        'txtPath
        '
        Me.txtPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPath.Location = New System.Drawing.Point(6, 29)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.ReadOnly = True
        Me.txtPath.Size = New System.Drawing.Size(266, 26)
        Me.txtPath.TabIndex = 2
        Me.txtPath.Text = "No Directory Selected"
        '
        'grpPath
        '
        Me.grpPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpPath.Controls.Add(Me.btnQuickPathCancel)
        Me.grpPath.Controls.Add(Me.btnQuickPathAct)
        Me.grpPath.Controls.Add(Me.txtQuickPath)
        Me.grpPath.Controls.Add(Me.txtPath)
        Me.grpPath.Location = New System.Drawing.Point(304, 102)
        Me.grpPath.Name = "grpPath"
        Me.grpPath.Size = New System.Drawing.Size(280, 94)
        Me.grpPath.TabIndex = 3
        Me.grpPath.TabStop = False
        Me.grpPath.Text = "&Current Path"
        '
        'btnQuickPathCancel
        '
        Me.btnQuickPathCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuickPathCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuickPathCancel.ImageIndex = 0
        Me.btnQuickPathCancel.ImageList = Me.imgQuickPath
        Me.btnQuickPathCancel.Location = New System.Drawing.Point(225, 63)
        Me.btnQuickPathCancel.Name = "btnQuickPathCancel"
        Me.btnQuickPathCancel.Size = New System.Drawing.Size(22, 22)
        Me.btnQuickPathCancel.TabIndex = 4
        Me.btnQuickPathCancel.UseVisualStyleBackColor = True
        Me.btnQuickPathCancel.Visible = False
        '
        'imgQuickPath
        '
        Me.imgQuickPath.ImageStream = CType(resources.GetObject("imgQuickPath.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgQuickPath.TransparentColor = System.Drawing.Color.Transparent
        Me.imgQuickPath.Images.SetKeyName(0, "quick-cancel.png")
        Me.imgQuickPath.Images.SetKeyName(1, "quick-folder.png")
        '
        'btnQuickPathAct
        '
        Me.btnQuickPathAct.Enabled = False
        Me.btnQuickPathAct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuickPathAct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuickPathAct.ImageIndex = 1
        Me.btnQuickPathAct.ImageList = Me.imgQuickPath
        Me.btnQuickPathAct.Location = New System.Drawing.Point(248, 63)
        Me.btnQuickPathAct.Name = "btnQuickPathAct"
        Me.btnQuickPathAct.Size = New System.Drawing.Size(22, 22)
        Me.btnQuickPathAct.TabIndex = 4
        Me.btnQuickPathAct.UseVisualStyleBackColor = True
        '
        'txtQuickPath
        '
        Me.txtQuickPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtQuickPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories
        Me.txtQuickPath.BackColor = System.Drawing.Color.White
        Me.txtQuickPath.Location = New System.Drawing.Point(6, 61)
        Me.txtQuickPath.Name = "txtQuickPath"
        Me.txtQuickPath.Size = New System.Drawing.Size(266, 26)
        Me.txtQuickPath.TabIndex = 3
        '
        't
        '
        Me.t.Enabled = True
        '
        'grpActions
        '
        Me.grpActions.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpActions.Controls.Add(Me.lblBlankRemoveRight)
        Me.grpActions.Controls.Add(Me.lblReplacedReplaceRight)
        Me.grpActions.Controls.Add(Me.Label1)
        Me.grpActions.Controls.Add(Me.lblRemovedTo)
        Me.grpActions.Controls.Add(Me.lblReplaceTo)
        Me.grpActions.Controls.Add(Me.lblAppendAdd)
        Me.grpActions.Controls.Add(Me.lblAppendOriginal)
        Me.grpActions.Controls.Add(Me.lblPrependAdd)
        Me.grpActions.Controls.Add(Me.lblPrependOriginal)
        Me.grpActions.Controls.Add(Me.lblOrignalReplaceLeft)
        Me.grpActions.Controls.Add(Me.lblPrepend)
        Me.grpActions.Controls.Add(Me.lblAppend)
        Me.grpActions.Controls.Add(Me.rbRemove)
        Me.grpActions.Controls.Add(Me.rbReplace)
        Me.grpActions.Controls.Add(Me.lblW)
        Me.grpActions.Controls.Add(Me.txtAppend)
        Me.grpActions.Controls.Add(Me.txtReplacedWith)
        Me.grpActions.Controls.Add(Me.txtPrepend)
        Me.grpActions.Controls.Add(Me.txtReplace)
        Me.grpActions.Location = New System.Drawing.Point(303, 202)
        Me.grpActions.Name = "grpActions"
        Me.grpActions.Size = New System.Drawing.Size(280, 297)
        Me.grpActions.TabIndex = 3
        Me.grpActions.TabStop = False
        Me.grpActions.Text = "&Rename"
        '
        'lblBlankRemoveRight
        '
        Me.lblBlankRemoveRight.AutoSize = True
        Me.lblBlankRemoveRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBlankRemoveRight.ImageIndex = 2
        Me.lblBlankRemoveRight.ImageList = Me.imgChanges
        Me.lblBlankRemoveRight.Location = New System.Drawing.Point(162, 257)
        Me.lblBlankRemoveRight.Name = "lblBlankRemoveRight"
        Me.lblBlankRemoveRight.Size = New System.Drawing.Size(30, 25)
        Me.lblBlankRemoveRight.TabIndex = 8
        Me.lblBlankRemoveRight.Text = "   "
        '
        'imgChanges
        '
        Me.imgChanges.ImageStream = CType(resources.GetObject("imgChanges.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgChanges.TransparentColor = System.Drawing.Color.Transparent
        Me.imgChanges.Images.SetKeyName(0, "change-original.png")
        Me.imgChanges.Images.SetKeyName(1, "change-replaced.png")
        Me.imgChanges.Images.SetKeyName(2, "change-blank.png")
        Me.imgChanges.Images.SetKeyName(3, "change-to.png")
        Me.imgChanges.Images.SetKeyName(4, "change-add.png")
        '
        'lblReplacedReplaceRight
        '
        Me.lblReplacedReplaceRight.AutoSize = True
        Me.lblReplacedReplaceRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReplacedReplaceRight.ImageIndex = 1
        Me.lblReplacedReplaceRight.ImageList = Me.imgChanges
        Me.lblReplacedReplaceRight.Location = New System.Drawing.Point(162, 129)
        Me.lblReplacedReplaceRight.Name = "lblReplacedReplaceRight"
        Me.lblReplacedReplaceRight.Size = New System.Drawing.Size(30, 25)
        Me.lblReplacedReplaceRight.TabIndex = 8
        Me.lblReplacedReplaceRight.Text = "   "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageIndex = 0
        Me.Label1.ImageList = Me.imgChanges
        Me.Label1.Location = New System.Drawing.Point(105, 257)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "   "
        '
        'lblRemovedTo
        '
        Me.lblRemovedTo.AutoSize = True
        Me.lblRemovedTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemovedTo.ImageIndex = 3
        Me.lblRemovedTo.ImageList = Me.imgChanges
        Me.lblRemovedTo.Location = New System.Drawing.Point(134, 257)
        Me.lblRemovedTo.Name = "lblRemovedTo"
        Me.lblRemovedTo.Size = New System.Drawing.Size(30, 25)
        Me.lblRemovedTo.TabIndex = 7
        Me.lblRemovedTo.Text = "   "
        '
        'lblReplaceTo
        '
        Me.lblReplaceTo.AutoSize = True
        Me.lblReplaceTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReplaceTo.ImageIndex = 3
        Me.lblReplaceTo.ImageList = Me.imgChanges
        Me.lblReplaceTo.Location = New System.Drawing.Point(134, 129)
        Me.lblReplaceTo.Name = "lblReplaceTo"
        Me.lblReplaceTo.Size = New System.Drawing.Size(30, 25)
        Me.lblReplaceTo.TabIndex = 7
        Me.lblReplaceTo.Text = "   "
        '
        'lblAppendAdd
        '
        Me.lblAppendAdd.AutoSize = True
        Me.lblAppendAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppendAdd.ImageIndex = 4
        Me.lblAppendAdd.ImageList = Me.imgChanges
        Me.lblAppendAdd.Location = New System.Drawing.Point(214, 48)
        Me.lblAppendAdd.Name = "lblAppendAdd"
        Me.lblAppendAdd.Size = New System.Drawing.Size(30, 25)
        Me.lblAppendAdd.TabIndex = 7
        Me.lblAppendAdd.Text = "   "
        '
        'lblAppendOriginal
        '
        Me.lblAppendOriginal.AutoSize = True
        Me.lblAppendOriginal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppendOriginal.ImageIndex = 0
        Me.lblAppendOriginal.ImageList = Me.imgChanges
        Me.lblAppendOriginal.Location = New System.Drawing.Point(241, 48)
        Me.lblAppendOriginal.Name = "lblAppendOriginal"
        Me.lblAppendOriginal.Size = New System.Drawing.Size(30, 25)
        Me.lblAppendOriginal.TabIndex = 7
        Me.lblAppendOriginal.Text = "   "
        '
        'lblPrependAdd
        '
        Me.lblPrependAdd.AutoSize = True
        Me.lblPrependAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrependAdd.ImageIndex = 4
        Me.lblPrependAdd.ImageList = Me.imgChanges
        Me.lblPrependAdd.Location = New System.Drawing.Point(33, 100)
        Me.lblPrependAdd.Name = "lblPrependAdd"
        Me.lblPrependAdd.Size = New System.Drawing.Size(30, 25)
        Me.lblPrependAdd.TabIndex = 7
        Me.lblPrependAdd.Text = "   "
        '
        'lblPrependOriginal
        '
        Me.lblPrependOriginal.AutoSize = True
        Me.lblPrependOriginal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrependOriginal.ImageIndex = 0
        Me.lblPrependOriginal.ImageList = Me.imgChanges
        Me.lblPrependOriginal.Location = New System.Drawing.Point(6, 100)
        Me.lblPrependOriginal.Name = "lblPrependOriginal"
        Me.lblPrependOriginal.Size = New System.Drawing.Size(30, 25)
        Me.lblPrependOriginal.TabIndex = 7
        Me.lblPrependOriginal.Text = "   "
        '
        'lblOrignalReplaceLeft
        '
        Me.lblOrignalReplaceLeft.AutoSize = True
        Me.lblOrignalReplaceLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrignalReplaceLeft.ImageIndex = 0
        Me.lblOrignalReplaceLeft.ImageList = Me.imgChanges
        Me.lblOrignalReplaceLeft.Location = New System.Drawing.Point(105, 129)
        Me.lblOrignalReplaceLeft.Name = "lblOrignalReplaceLeft"
        Me.lblOrignalReplaceLeft.Size = New System.Drawing.Size(30, 25)
        Me.lblOrignalReplaceLeft.TabIndex = 7
        Me.lblOrignalReplaceLeft.Text = "   "
        '
        'lblPrepend
        '
        Me.lblPrepend.AutoSize = True
        Me.lblPrepend.ImageList = Me.imgChanges
        Me.lblPrepend.Location = New System.Drawing.Point(6, 22)
        Me.lblPrepend.Name = "lblPrepend"
        Me.lblPrepend.Size = New System.Drawing.Size(71, 20)
        Me.lblPrepend.TabIndex = 6
        Me.lblPrepend.Text = "&Prepend"
        '
        'lblAppend
        '
        Me.lblAppend.AutoSize = True
        Me.lblAppend.Location = New System.Drawing.Point(6, 74)
        Me.lblAppend.Name = "lblAppend"
        Me.lblAppend.Size = New System.Drawing.Size(65, 20)
        Me.lblAppend.TabIndex = 6
        Me.lblAppend.Text = "&Append"
        '
        'rbRemove
        '
        Me.rbRemove.AutoSize = True
        Me.rbRemove.Location = New System.Drawing.Point(6, 257)
        Me.rbRemove.Name = "rbRemove"
        Me.rbRemove.Size = New System.Drawing.Size(88, 24)
        Me.rbRemove.TabIndex = 5
        Me.rbRemove.TabStop = True
        Me.rbRemove.Text = "Re&move"
        Me.rbRemove.UseVisualStyleBackColor = True
        '
        'rbReplace
        '
        Me.rbReplace.AutoSize = True
        Me.rbReplace.Checked = True
        Me.rbReplace.Location = New System.Drawing.Point(6, 129)
        Me.rbReplace.Name = "rbReplace"
        Me.rbReplace.Size = New System.Drawing.Size(93, 24)
        Me.rbReplace.TabIndex = 4
        Me.rbReplace.TabStop = True
        Me.rbReplace.Text = "Re&place:"
        Me.rbReplace.UseVisualStyleBackColor = True
        '
        'lblW
        '
        Me.lblW.AutoSize = True
        Me.lblW.Location = New System.Drawing.Point(6, 197)
        Me.lblW.Name = "lblW"
        Me.lblW.Size = New System.Drawing.Size(48, 20)
        Me.lblW.TabIndex = 3
        Me.lblW.Text = "&With:"
        '
        'txtAppend
        '
        Me.txtAppend.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAppend.Location = New System.Drawing.Point(65, 100)
        Me.txtAppend.Name = "txtAppend"
        Me.txtAppend.Size = New System.Drawing.Size(206, 26)
        Me.txtAppend.TabIndex = 2
        Me.txtAppend.Tag = "1"
        '
        'txtReplacedWith
        '
        Me.txtReplacedWith.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtReplacedWith.Location = New System.Drawing.Point(6, 225)
        Me.txtReplacedWith.Name = "txtReplacedWith"
        Me.txtReplacedWith.Size = New System.Drawing.Size(265, 26)
        Me.txtReplacedWith.TabIndex = 2
        Me.txtReplacedWith.Tag = "1"
        Me.txtReplacedWith.Text = "With Me"
        '
        'txtPrepend
        '
        Me.txtPrepend.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPrepend.Location = New System.Drawing.Point(6, 47)
        Me.txtPrepend.Name = "txtPrepend"
        Me.txtPrepend.Size = New System.Drawing.Size(206, 26)
        Me.txtPrepend.TabIndex = 2
        Me.txtPrepend.Tag = "1"
        '
        'txtReplace
        '
        Me.txtReplace.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtReplace.Location = New System.Drawing.Point(7, 164)
        Me.txtReplace.Name = "txtReplace"
        Me.txtReplace.Size = New System.Drawing.Size(265, 26)
        Me.txtReplace.TabIndex = 2
        Me.txtReplace.Tag = "1"
        Me.txtReplace.Text = "Replace Me"
        '
        'btnNone
        '
        Me.btnNone.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNone.ImageIndex = 2
        Me.btnNone.ImageList = Me.imgBtnChangeSelection
        Me.btnNone.Location = New System.Drawing.Point(496, 58)
        Me.btnNone.Margin = New System.Windows.Forms.Padding(5)
        Me.btnNone.Name = "btnNone"
        Me.btnNone.Size = New System.Drawing.Size(87, 36)
        Me.btnNone.TabIndex = 1
        Me.btnNone.Text = "&None"
        Me.btnNone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNone.UseVisualStyleBackColor = True
        '
        'btnInvert
        '
        Me.btnInvert.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInvert.ImageIndex = 1
        Me.btnInvert.ImageList = Me.imgBtnChangeSelection
        Me.btnInvert.Location = New System.Drawing.Point(401, 58)
        Me.btnInvert.Margin = New System.Windows.Forms.Padding(5)
        Me.btnInvert.Name = "btnInvert"
        Me.btnInvert.Size = New System.Drawing.Size(87, 36)
        Me.btnInvert.TabIndex = 1
        Me.btnInvert.Text = "&Invert"
        Me.btnInvert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInvert.UseVisualStyleBackColor = True
        '
        'btnAll
        '
        Me.btnAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAll.ImageIndex = 0
        Me.btnAll.ImageList = Me.imgBtnChangeSelection
        Me.btnAll.Location = New System.Drawing.Point(304, 58)
        Me.btnAll.Margin = New System.Windows.Forms.Padding(5)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(87, 36)
        Me.btnAll.TabIndex = 1
        Me.btnAll.Text = "&All"
        Me.btnAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAll.UseVisualStyleBackColor = True
        '
        'btnAct
        '
        Me.btnAct.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAct.ImageIndex = 1
        Me.btnAct.ImageList = Me.imgBtnActs
        Me.btnAct.Location = New System.Drawing.Point(484, 12)
        Me.btnAct.Margin = New System.Windows.Forms.Padding(5)
        Me.btnAct.Name = "btnAct"
        Me.btnAct.Size = New System.Drawing.Size(99, 36)
        Me.btnAct.TabIndex = 1
        Me.btnAct.Text = "Ac&t"
        Me.btnAct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAct.UseVisualStyleBackColor = True
        '
        'imgBtnActs
        '
        Me.imgBtnActs.ImageStream = CType(resources.GetObject("imgBtnActs.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgBtnActs.TransparentColor = System.Drawing.Color.Transparent
        Me.imgBtnActs.Images.SetKeyName(0, "act-choose.png")
        Me.imgBtnActs.Images.SetKeyName(1, "act-act.png")
        '
        'btnDir
        '
        Me.btnDir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDir.ImageIndex = 0
        Me.btnDir.ImageList = Me.imgBtnActs
        Me.btnDir.Location = New System.Drawing.Point(304, 12)
        Me.btnDir.Margin = New System.Windows.Forms.Padding(5)
        Me.btnDir.Name = "btnDir"
        Me.btnDir.Size = New System.Drawing.Size(163, 36)
        Me.btnDir.TabIndex = 1
        Me.btnDir.Text = "&Get Directory"
        Me.btnDir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDir.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 509)
        Me.Controls.Add(Me.grpActions)
        Me.Controls.Add(Me.grpPath)
        Me.Controls.Add(Me.btnNone)
        Me.Controls.Add(Me.btnInvert)
        Me.Controls.Add(Me.btnAll)
        Me.Controls.Add(Me.btnAct)
        Me.Controls.Add(Me.btnDir)
        Me.Controls.Add(Me.chlb)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.10084!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "Mass Rename"
        Me.ctxMenuFileSelect.ResumeLayout(False)
        Me.grpPath.ResumeLayout(False)
        Me.grpPath.PerformLayout()
        Me.grpActions.ResumeLayout(False)
        Me.grpActions.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chlb As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnDir As System.Windows.Forms.Button
    Friend WithEvents btnAct As System.Windows.Forms.Button
    Friend WithEvents btnAll As System.Windows.Forms.Button
    Friend WithEvents btnInvert As System.Windows.Forms.Button
    Friend WithEvents btnNone As System.Windows.Forms.Button
    Friend WithEvents fbd As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents grpPath As System.Windows.Forms.GroupBox
    Friend WithEvents t As System.Windows.Forms.Timer
    Friend WithEvents grpActions As System.Windows.Forms.GroupBox
    Friend WithEvents txtReplace As System.Windows.Forms.TextBox
    Friend WithEvents lblW As System.Windows.Forms.Label
    Friend WithEvents txtReplacedWith As System.Windows.Forms.TextBox
    Friend WithEvents rbRemove As System.Windows.Forms.RadioButton
    Friend WithEvents rbReplace As System.Windows.Forms.RadioButton
    Friend WithEvents txtAppend As System.Windows.Forms.TextBox
    Friend WithEvents txtPrepend As System.Windows.Forms.TextBox
    Friend WithEvents btnQuickPathAct As System.Windows.Forms.Button
    Friend WithEvents txtQuickPath As System.Windows.Forms.TextBox
    Friend WithEvents imgBtnChangeSelection As System.Windows.Forms.ImageList
    Friend WithEvents btnQuickPathCancel As System.Windows.Forms.Button
    Friend WithEvents imgQuickPath As System.Windows.Forms.ImageList
    Friend WithEvents lblPrepend As System.Windows.Forms.Label
    Friend WithEvents lblAppend As System.Windows.Forms.Label
    Friend WithEvents imgChanges As System.Windows.Forms.ImageList
    Friend WithEvents lblOrignalReplaceLeft As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblBlankRemoveRight As System.Windows.Forms.Label
    Friend WithEvents lblReplacedReplaceRight As System.Windows.Forms.Label
    Friend WithEvents lblRemovedTo As System.Windows.Forms.Label
    Friend WithEvents lblReplaceTo As System.Windows.Forms.Label
    Friend WithEvents lblAppendAdd As System.Windows.Forms.Label
    Friend WithEvents lblAppendOriginal As System.Windows.Forms.Label
    Friend WithEvents lblPrependAdd As System.Windows.Forms.Label
    Friend WithEvents lblPrependOriginal As System.Windows.Forms.Label
    Friend WithEvents ctxMenuFileSelect As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ctxDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ctxAttributes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ctxSeperator1AttrDel As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ctxDeleteConfirm As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ctxDeleteConfirmed As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ctxReadOnly As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ctxMakeReadOnly As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ctxNoReadOnly As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ctxHidden As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ctxMakeHidden As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ctxNoHidden As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ctxArchive As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ctxMakeArchive As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ctxNoArchive As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ctxSystem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ctxMakeSystem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ctxNoSystem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents imgBtnActs As System.Windows.Forms.ImageList

End Class
