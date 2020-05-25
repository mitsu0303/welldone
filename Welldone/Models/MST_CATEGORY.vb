Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel

Public Class MST_CATEGORY
    <Key()>
    <DisplayName("カテゴリーID")>
    Public Property CATEGORY_ID As String

    <DisplayName("カテゴリー")>
    Public Property CATEGORY As String

    <DisplayName("削除フラグ")>
    Public Property DEL_FLG As String

    Public Overridable Property MST_SHOPs As ICollection(Of MST_SHOP) ' 店

End Class
