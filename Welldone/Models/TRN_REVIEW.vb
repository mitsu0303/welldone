Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel

Public Class TRN_REVIEW
    <Key()>
    <DisplayName("口コミID")>
    Public Property REVIEW_ID As String

    <DisplayName("店ID")>
    Public Property SHOP_ID As String

    <DisplayName("投稿者")>
    Public Property CONTRIBUTOR As String

    <DisplayName("評価")>
    Public Property EVALUATION As Single

    <DisplayName("コメント")>
    Public Property COMMENT As Single

    <DisplayName("削除フラグ")>
    Public Property DEL_FLG As String
End Class
