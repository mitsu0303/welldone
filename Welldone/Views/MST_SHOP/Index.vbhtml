@ModelType IEnumerable(Of Welldone.MST_SHOP)
@Code
    ViewData("Title") = "Index"
End Code

<h2>Index</h2>



<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.SHOP_NAME)
        </th>
        <th>
            カテゴリー
        </th>
        <th>
            口コミ数
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ADDRESS)
        </th>
        <th>
            営業時間
        </th>
        <th>
            口コミ登録
        </th>
    </tr>

    @For Each item In Model
        @<tr>
    <td>
        @Html.ActionLink(item.SHOP_NAME, "Edit", New With {.id = item.SHOP_ID})
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.CATEGORY_ID)
    </td>
    <td>
        ' 口コミ数
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.ADDRESS)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.OPEN_TIME) ～
        @Html.DisplayFor(Function(modelItem) item.CLOSE_TIME)
    </td>
    <td>
        <input type="button" value="口コミ登録" onclick="location.href='/TRN_REVIEW/Create'" class="btn btn-default" />
    </td>
</tr>
    Next

</table>

<input type="button" value="お店登録" onclick="location.href='/MST_SHOP/Create'" class="btn btn-default" />

