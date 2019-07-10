<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.cbCategory = New System.Windows.Forms.ComboBox()
        Me.dgvMs = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnRpt = New System.Windows.Forms.Button()
        Me.cbReport = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnComputeTotalAll = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnComputeTop10 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblMs = New System.Windows.Forms.Label()
        CType(Me.dgvMs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.SystemColors.Control
        Me.btnStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.ForeColor = System.Drawing.Color.Black
        Me.btnStop.Location = New System.Drawing.Point(216, 68)
        Me.btnStop.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(140, 39)
        Me.btnStop.TabIndex = 9
        Me.btnStop.Text = "Stop !"
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.SystemColors.Control
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.Black
        Me.btnStart.Location = New System.Drawing.Point(8, 68)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(140, 39)
        Me.btnStart.TabIndex = 8
        Me.btnStart.Text = "Start !"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'cbCategory
        '
        Me.cbCategory.BackColor = System.Drawing.SystemColors.Control
        Me.cbCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCategory.ForeColor = System.Drawing.Color.Black
        Me.cbCategory.FormattingEnabled = True
        Me.cbCategory.Location = New System.Drawing.Point(8, 23)
        Me.cbCategory.Margin = New System.Windows.Forms.Padding(4)
        Me.cbCategory.Name = "cbCategory"
        Me.cbCategory.Size = New System.Drawing.Size(348, 37)
        Me.cbCategory.TabIndex = 7
        '
        'dgvMs
        '
        Me.dgvMs.AllowUserToAddRows = False
        Me.dgvMs.AllowUserToDeleteRows = False
        Me.dgvMs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMs.BackgroundColor = System.Drawing.Color.White
        Me.dgvMs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.dgvMs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMs.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvMs.GridColor = System.Drawing.SystemColors.ButtonShadow
        Me.dgvMs.Location = New System.Drawing.Point(424, 13)
        Me.dgvMs.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvMs.Name = "dgvMs"
        Me.dgvMs.ReadOnly = True
        Me.dgvMs.RowHeadersWidth = 40
        Me.dgvMs.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvMs.RowTemplate.Height = 37
        Me.dgvMs.Size = New System.Drawing.Size(825, 647)
        Me.dgvMs.TabIndex = 10
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.btnRpt)
        Me.GroupBox3.Controls.Add(Me.cbReport)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(13, 164)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(363, 113)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Report Generator"
        '
        'btnRpt
        '
        Me.btnRpt.BackColor = System.Drawing.SystemColors.Control
        Me.btnRpt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRpt.ForeColor = System.Drawing.Color.Black
        Me.btnRpt.Location = New System.Drawing.Point(118, 71)
        Me.btnRpt.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRpt.Name = "btnRpt"
        Me.btnRpt.Size = New System.Drawing.Size(109, 32)
        Me.btnRpt.TabIndex = 5
        Me.btnRpt.Text = "Report !!"
        Me.btnRpt.UseVisualStyleBackColor = False
        '
        'cbReport
        '
        Me.cbReport.BackColor = System.Drawing.SystemColors.Control
        Me.cbReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbReport.ForeColor = System.Drawing.Color.Black
        Me.cbReport.FormattingEnabled = True
        Me.cbReport.Location = New System.Drawing.Point(8, 25)
        Me.cbReport.Margin = New System.Windows.Forms.Padding(4)
        Me.cbReport.Name = "cbReport"
        Me.cbReport.Size = New System.Drawing.Size(347, 38)
        Me.cbReport.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox4.Controls.Add(Me.btnComputeTotalAll)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(13, 305)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(363, 63)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Total"
        '
        'btnComputeTotalAll
        '
        Me.btnComputeTotalAll.BackColor = System.Drawing.SystemColors.Control
        Me.btnComputeTotalAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComputeTotalAll.ForeColor = System.Drawing.Color.Black
        Me.btnComputeTotalAll.Location = New System.Drawing.Point(107, 23)
        Me.btnComputeTotalAll.Margin = New System.Windows.Forms.Padding(4)
        Me.btnComputeTotalAll.Name = "btnComputeTotalAll"
        Me.btnComputeTotalAll.Size = New System.Drawing.Size(156, 32)
        Me.btnComputeTotalAll.TabIndex = 6
        Me.btnComputeTotalAll.Text = "Total Din !"
        Me.btnComputeTotalAll.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.btnComputeTop10)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(13, 526)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(363, 63)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Top 5"
        '
        'btnComputeTop10
        '
        Me.btnComputeTop10.BackColor = System.Drawing.SystemColors.Control
        Me.btnComputeTop10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComputeTop10.ForeColor = System.Drawing.Color.Black
        Me.btnComputeTop10.Location = New System.Drawing.Point(118, 23)
        Me.btnComputeTop10.Margin = New System.Windows.Forms.Padding(4)
        Me.btnComputeTop10.Name = "btnComputeTop10"
        Me.btnComputeTop10.Size = New System.Drawing.Size(156, 32)
        Me.btnComputeTop10.TabIndex = 5
        Me.btnComputeTop10.Text = "Get Top 5"
        Me.btnComputeTop10.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox5.Controls.Add(Me.cbCategory)
        Me.GroupBox5.Controls.Add(Me.btnStart)
        Me.GroupBox5.Controls.Add(Me.btnStop)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Black
        Me.GroupBox5.Location = New System.Drawing.Point(13, 39)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(363, 117)
        Me.GroupBox5.TabIndex = 13
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Category"
        '
        'lblMs
        '
        Me.lblMs.AutoSize = True
        Me.lblMs.BackColor = System.Drawing.SystemColors.Control
        Me.lblMs.ForeColor = System.Drawing.Color.Black
        Me.lblMs.Location = New System.Drawing.Point(18, 13)
        Me.lblMs.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMs.Name = "lblMs"
        Me.lblMs.Size = New System.Drawing.Size(51, 17)
        Me.lblMs.TabIndex = 17
        Me.lblMs.Text = "Label1"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(Me.lblMs)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.dgvMs)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Scores"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvMs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStop As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents cbCategory As ComboBox
    Friend WithEvents dgvMs As DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnRpt As Button
    Friend WithEvents cbReport As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnComputeTotalAll As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnComputeTop10 As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents lblMs As Label
End Class
