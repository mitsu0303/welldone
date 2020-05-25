Imports System.Data.Entity

Public Class MyMvcContext : Inherits DbContext
    Public Property MST_SHOPs As DbSet(Of MST_SHOP) ' MST_SHOPテーブル
    Public Property MST_CATEGORYs As DbSet(Of MST_CATEGORY) ' MST_CATEGORYテーブル
    Public Property TRN_REVIEWs As DbSet(Of TRN_REVIEW) ' TRN_REVIEWテーブル
End Class
