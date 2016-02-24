<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCollegeMajors
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
        Me.components = New System.ComponentModel.Container()
        Dim DepartmentLabel As System.Windows.Forms.Label
        Dim DegreeLabel As System.Windows.Forms.Label
        Dim Number_in_DegreeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCollegeMajors))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.CollegeDataSet = New CollegeMajors.collegeDataSet()
        Me.CollegeMajorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CollegeMajorsTableAdapter = New CollegeMajors.collegeDataSetTableAdapters.CollegeMajorsTableAdapter()
        Me.TableAdapterManager = New CollegeMajors.collegeDataSetTableAdapters.TableAdapterManager()
        Me.CollegeMajorsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CollegeMajorsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DepartmentTextBox = New System.Windows.Forms.TextBox()
        Me.DegreeComboBox = New System.Windows.Forms.ComboBox()
        Me.Number_in_DegreeTextBox = New System.Windows.Forms.TextBox()
        Me.picCollege = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTotalMajors = New System.Windows.Forms.Button()
        Me.lblTotalMajors = New System.Windows.Forms.Label()
        Me.lblPercentageOfMajors = New System.Windows.Forms.Label()
        DepartmentLabel = New System.Windows.Forms.Label()
        DegreeLabel = New System.Windows.Forms.Label()
        Number_in_DegreeLabel = New System.Windows.Forms.Label()
        CType(Me.CollegeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CollegeMajorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CollegeMajorsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CollegeMajorsBindingNavigator.SuspendLayout()
        CType(Me.picCollege, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DepartmentLabel
        '
        DepartmentLabel.AutoSize = True
        DepartmentLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DepartmentLabel.ForeColor = System.Drawing.Color.Navy
        DepartmentLabel.Location = New System.Drawing.Point(176, 263)
        DepartmentLabel.Name = "DepartmentLabel"
        DepartmentLabel.Size = New System.Drawing.Size(91, 16)
        DepartmentLabel.TabIndex = 2
        DepartmentLabel.Text = "Department:"
        '
        'DegreeLabel
        '
        DegreeLabel.AutoSize = True
        DegreeLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DegreeLabel.ForeColor = System.Drawing.Color.Navy
        DegreeLabel.Location = New System.Drawing.Point(176, 318)
        DegreeLabel.Name = "DegreeLabel"
        DegreeLabel.Size = New System.Drawing.Size(60, 16)
        DegreeLabel.TabIndex = 4
        DegreeLabel.Text = "Degree:"
        '
        'Number_in_DegreeLabel
        '
        Number_in_DegreeLabel.AutoSize = True
        Number_in_DegreeLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Number_in_DegreeLabel.ForeColor = System.Drawing.Color.Navy
        Number_in_DegreeLabel.Location = New System.Drawing.Point(176, 373)
        Number_in_DegreeLabel.Name = "Number_in_DegreeLabel"
        Number_in_DegreeLabel.Size = New System.Drawing.Size(130, 16)
        Number_in_DegreeLabel.TabIndex = 6
        Number_in_DegreeLabel.Text = "Number in Degree:"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Navy
        Me.lblTitle.Location = New System.Drawing.Point(141, 36)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(280, 38)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "College Majors"
        '
        'CollegeDataSet
        '
        Me.CollegeDataSet.DataSetName = "collegeDataSet"
        Me.CollegeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CollegeMajorsBindingSource
        '
        Me.CollegeMajorsBindingSource.DataMember = "CollegeMajors"
        Me.CollegeMajorsBindingSource.DataSource = Me.CollegeDataSet
        '
        'CollegeMajorsTableAdapter
        '
        Me.CollegeMajorsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CollegeMajorsTableAdapter = Me.CollegeMajorsTableAdapter
        Me.TableAdapterManager.UpdateOrder = CollegeMajors.collegeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CollegeMajorsBindingNavigator
        '
        Me.CollegeMajorsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CollegeMajorsBindingNavigator.BindingSource = Me.CollegeMajorsBindingSource
        Me.CollegeMajorsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CollegeMajorsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CollegeMajorsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CollegeMajorsBindingNavigatorSaveItem})
        Me.CollegeMajorsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CollegeMajorsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CollegeMajorsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CollegeMajorsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CollegeMajorsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CollegeMajorsBindingNavigator.Name = "CollegeMajorsBindingNavigator"
        Me.CollegeMajorsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CollegeMajorsBindingNavigator.Size = New System.Drawing.Size(575, 25)
        Me.CollegeMajorsBindingNavigator.TabIndex = 1
        Me.CollegeMajorsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'CollegeMajorsBindingNavigatorSaveItem
        '
        Me.CollegeMajorsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CollegeMajorsBindingNavigatorSaveItem.Image = CType(resources.GetObject("CollegeMajorsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CollegeMajorsBindingNavigatorSaveItem.Name = "CollegeMajorsBindingNavigatorSaveItem"
        Me.CollegeMajorsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CollegeMajorsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DepartmentTextBox
        '
        Me.DepartmentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CollegeMajorsBindingSource, "Department", True))
        Me.DepartmentTextBox.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepartmentTextBox.ForeColor = System.Drawing.Color.Navy
        Me.DepartmentTextBox.Location = New System.Drawing.Point(398, 260)
        Me.DepartmentTextBox.Name = "DepartmentTextBox"
        Me.DepartmentTextBox.Size = New System.Drawing.Size(44, 23)
        Me.DepartmentTextBox.TabIndex = 3
        '
        'DegreeComboBox
        '
        Me.DegreeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CollegeMajorsBindingSource, "Degree", True))
        Me.DegreeComboBox.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DegreeComboBox.ForeColor = System.Drawing.Color.Navy
        Me.DegreeComboBox.FormattingEnabled = True
        Me.DegreeComboBox.Location = New System.Drawing.Point(268, 315)
        Me.DegreeComboBox.Name = "DegreeComboBox"
        Me.DegreeComboBox.Size = New System.Drawing.Size(174, 24)
        Me.DegreeComboBox.TabIndex = 5
        '
        'Number_in_DegreeTextBox
        '
        Me.Number_in_DegreeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CollegeMajorsBindingSource, "Number in Degree", True))
        Me.Number_in_DegreeTextBox.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Number_in_DegreeTextBox.ForeColor = System.Drawing.Color.Navy
        Me.Number_in_DegreeTextBox.Location = New System.Drawing.Point(411, 370)
        Me.Number_in_DegreeTextBox.Name = "Number_in_DegreeTextBox"
        Me.Number_in_DegreeTextBox.Size = New System.Drawing.Size(31, 23)
        Me.Number_in_DegreeTextBox.TabIndex = 7
        '
        'picCollege
        '
        Me.picCollege.Image = CType(resources.GetObject("picCollege.Image"), System.Drawing.Image)
        Me.picCollege.Location = New System.Drawing.Point(179, 89)
        Me.picCollege.Name = "picCollege"
        Me.picCollege.Size = New System.Drawing.Size(203, 132)
        Me.picCollege.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCollege.TabIndex = 8
        Me.picCollege.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Label1"
        '
        'btnTotalMajors
        '
        Me.btnTotalMajors.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotalMajors.ForeColor = System.Drawing.Color.Navy
        Me.btnTotalMajors.Location = New System.Drawing.Point(241, 466)
        Me.btnTotalMajors.Name = "btnTotalMajors"
        Me.btnTotalMajors.Size = New System.Drawing.Size(88, 28)
        Me.btnTotalMajors.TabIndex = 11
        Me.btnTotalMajors.Text = "Find Total"
        Me.btnTotalMajors.UseVisualStyleBackColor = True
        '
        'lblTotalMajors
        '
        Me.lblTotalMajors.AutoSize = True
        Me.lblTotalMajors.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalMajors.ForeColor = System.Drawing.Color.Navy
        Me.lblTotalMajors.Location = New System.Drawing.Point(63, 521)
        Me.lblTotalMajors.Name = "lblTotalMajors"
        Me.lblTotalMajors.Size = New System.Drawing.Size(448, 16)
        Me.lblTotalMajors.TabIndex = 10
        Me.lblTotalMajors.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.lblTotalMajors.Visible = False
        '
        'lblPercentageOfMajors
        '
        Me.lblPercentageOfMajors.AutoSize = True
        Me.lblPercentageOfMajors.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercentageOfMajors.ForeColor = System.Drawing.Color.Navy
        Me.lblPercentageOfMajors.Location = New System.Drawing.Point(103, 422)
        Me.lblPercentageOfMajors.Name = "lblPercentageOfMajors"
        Me.lblPercentageOfMajors.Size = New System.Drawing.Size(368, 18)
        Me.lblPercentageOfMajors.TabIndex = 12
        Me.lblPercentageOfMajors.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.lblPercentageOfMajors.Visible = False
        '
        'frmCollegeMajors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(575, 584)
        Me.Controls.Add(Me.lblPercentageOfMajors)
        Me.Controls.Add(Me.btnTotalMajors)
        Me.Controls.Add(Me.lblTotalMajors)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picCollege)
        Me.Controls.Add(Number_in_DegreeLabel)
        Me.Controls.Add(Me.Number_in_DegreeTextBox)
        Me.Controls.Add(DegreeLabel)
        Me.Controls.Add(Me.DegreeComboBox)
        Me.Controls.Add(DepartmentLabel)
        Me.Controls.Add(Me.DepartmentTextBox)
        Me.Controls.Add(Me.CollegeMajorsBindingNavigator)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmCollegeMajors"
        Me.Text = "College Majors"
        CType(Me.CollegeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CollegeMajorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CollegeMajorsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CollegeMajorsBindingNavigator.ResumeLayout(False)
        Me.CollegeMajorsBindingNavigator.PerformLayout()
        CType(Me.picCollege, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents CollegeDataSet As CollegeMajors.collegeDataSet
    Friend WithEvents CollegeMajorsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CollegeMajorsTableAdapter As CollegeMajors.collegeDataSetTableAdapters.CollegeMajorsTableAdapter
    Friend WithEvents TableAdapterManager As CollegeMajors.collegeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CollegeMajorsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CollegeMajorsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DepartmentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DegreeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Number_in_DegreeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents picCollege As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnTotalMajors As System.Windows.Forms.Button
    Friend WithEvents lblTotalMajors As System.Windows.Forms.Label
    Friend WithEvents lblPercentageOfMajors As System.Windows.Forms.Label

End Class
