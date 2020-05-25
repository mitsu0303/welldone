Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel


Public Class MST_SHOP
    '<Required(ErrorMessage:="{0}は必須です。")>
    '<RegularExpression("[0-9]{4}", ErrorMessage:="{0}は数値4桁で入力してください。")>
    <Key()>
    <DisplayName("店ID")>
    Public Property SHOP_ID As String

    <DisplayName("店名")>
    <Required(ErrorMessage:="{0}は必須です。")>
    Public Property SHOP_NAME As String

    <DisplayName("カテゴリーID")>
    <Required(ErrorMessage:="{0}は必須です。")>
    <RegularExpression("[0-9]{4}", ErrorMessage:="{0}は数値4桁で入力してください。")>
    Public Property CATEGORY_ID As String

    <DisplayName("住所")>
    <StringLength(100, ErrorMessage:="{0}は{1}文字以内で入力してください。")>
    Public Property ADDRESS As String

    <DisplayName("開店時間")>
    <Required(ErrorMessage:="{0}は必須です。")>
    <RegularExpression("[0-9]{2}:[0-9]{2}", ErrorMessage:="{0}は00:00の形式で入力してください。")>
    Public Property OPEN_TIME As String

    <DisplayName("閉店時間")>
    <Required(ErrorMessage:="{0}は必須です。")>
    <RegularExpression("[0-9]{2}:[0-9]{2}", ErrorMessage:="{0}は00:00の形式で入力してください。")>
    Public Property CLOSE_TIME As String

    <DisplayName("説明")>
    <StringLength(100, ErrorMessage:="{0}は{1}文字以内で入力してください。")>
    Public Property DESCRIPTION As String

    <Required(ErrorMessage:="{0}は必須です。")>
    <StringLength(1, ErrorMessage:="{0}は{1}文字以内で入力してください。")>
    <DisplayName("削除フラグ")>
    Public Property DEL_FLG As String

    Public Overridable Property MST_CATEGORYs As ICollection(Of MST_CATEGORY) ' カテゴリー
End Class
