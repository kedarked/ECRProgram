Imports System.Data.SqlClient

Module Module1
    'Create ADO Objects
    Public myConn As SqlConnection
    Public myCmd As SqlCommand
    Public myReader As SqlDataReader
    Public results As String

    Public iECRNo_old As Integer
    Public iECRNo_new As Integer
    Public iRadioButtonValue As Integer

    Public sStr1 As String
    Public sStr2 As String
    Public sStr3 As String
    Public sStr4 As String
    Public sStr5 As String
    Public sStr6 As String

    Public iInt1 As Integer
    Public iInt2 As Integer
    Public iInt3 As Integer
    Public iInt4 As Integer
    Public iInt5 As Integer

    Public sStatus As String
    Public sJobNum As String
    Public sPersonnel As String
    Public sIssueDate As String
    Public sNeedDate As String
    Public sRevision As String
    Public sCategory As String
    Public sCompDate As String
    Public sComments As String
    Public sRequest As String
    Public iCheckBoxValue As Integer
    Public bExists As Boolean

    Public bApproved As Boolean
    Public bEnggChanged As Boolean = False
    Public bPurchChanged As Boolean = False
    Public bAccChanged As Boolean = False
    Public bQuantityChanged As Boolean = False
    Public bLogisticsChanged As Boolean = False
    Public bProdChanged As Boolean = False

    Public iAccept As Integer
    Public iDispo As Integer

    Public bCancel As Boolean



End Module
