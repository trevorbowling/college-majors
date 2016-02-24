' Program Name: College Majors Window Application
' Author:       Trevor Anthony Bowling
' Date:         March 27, 2014
' Purpose:      The College Majors Windows Application opens an
'               Access database with the college majors in
'               a Windows form. The datbase can be viewed, updated, and
'               deleted. The application computes the total of the
'               students presently in majors that have been entered into 
'               the database. The user can also view the percentage of 
'               students at the college participating in that major.

Option Strict On

Public Class frmCollegeMajors

    Private Sub CollegeMajorsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CollegeMajorsBindingNavigatorSaveItem.Click
        ' This click event is created by the Database Wizard

            Me.Validate()
            Me.CollegeMajorsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CollegeDataSet)

    End Sub

    Private Sub frmCollegeMajors_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' The Database Wizard creates this method 
        ' The Try-Catch block catches an exception caused by a missing database file

        Try
            'TODO: This line of code loads data into the 'CollegeDataSet.CollegeMajors' table. You can move, or remove it, as needed.
            Me.CollegeMajorsTableAdapter.Fill(Me.CollegeDataSet.CollegeMajors)
        Catch ex As Exception
            MsgBox("The Database File is Unavailable", , "Error")
            Close()
        End Try

    End Sub

    Private Sub btnTotalMajors_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTotalMajors.Click
        ' strSQL is a SQL statement that selects all the fields from
        ' the CollegeMajors table

        Dim strSQL As String = "SELECT * FROM CollegeMajors"

        ' strPath provides the database type and path of the college database
        Dim strPath As String = "Provider=Microsoft.ACE.OLEDB.12.0 ;" _
                                & "Data Source=G:\college.accdb"
        Dim odacollege As New OleDb.OleDbDataAdapter(strSQL, strPath)
        Dim intCount As Integer
        Dim datMajorStudents As New DataTable
        Dim decTotalMajors As Decimal = 0D

        ' The DataTable name datMajorStudents is filled with the tabe data
        odacollege.Fill(datMajorStudents)
        ' The connection to the database is disconnected
        odacollege.Dispose()
        For intCount = 0 To datMajorStudents.Rows.Count - 1
            decTotalMajors += Convert.ToDecimal(datMajorStudents.Rows(intCount)("Number In Degree"))
        Next
        lblTotalMajors.Visible = True
        lblTotalMajors.Text = "The total number of students presently in majors is " _
        & decTotalMajors.ToString()
    End Sub

End Class
