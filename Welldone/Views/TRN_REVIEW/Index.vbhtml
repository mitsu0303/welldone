@ModelType IEnumerable(Of Welldone.TRN_REVIEW)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.SHOP_ID)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.CONTRIBUTOR)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.EVALUATION)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.DEL_FLG)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.SHOP_ID)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.CONTRIBUTOR)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.EVALUATION)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DEL_FLG)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.REVIEW_ID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.REVIEW_ID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.REVIEW_ID })
        </td>
    </tr>
Next

</table>
