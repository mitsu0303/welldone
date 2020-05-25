Imports System.Data.Entity

Public Class MyMvcInitializer

    Inherits DropCreateDatabaseAlways(Of MyMvcContext)

    Protected Overrides Sub Seed(context As MyMvcContext)

        Dim MST_SHOPs = New List(Of MST_SHOP)() From {
            New MST_SHOP() With {.SHOP_ID = "0001",
                                 .SHOP_NAME = "焼肉カルビ",
                                 .CATEGORY_ID = "0001",
                                 .ADDRESS = "兵庫県神戸市",
                                 .OPEN_TIME = "11:30",
                                 .CLOSE_TIME = "23:00",
                                 .DESCRIPTION = "説明",
                                 .DEL_FLG = "0"},
            New MST_SHOP() With {.SHOP_ID = "0002",
                                 .SHOP_NAME = "海鮮野郎",
                                 .CATEGORY_ID = "0002",
                                 .ADDRESS = "兵庫県神戸市",
                                 .OPEN_TIME = "17:00",
                                 .CLOSE_TIME = "24:00",
                                 .DESCRIPTION = "説明",
                                 .DEL_FLG = "0"}
        }

        MST_SHOPs.ForEach(Function(b) context.MST_SHOPs.Add(b))
        context.SaveChanges()

        Dim MST_CATEGORYs = New List(Of MST_CATEGORY)() From {
            New MST_CATEGORY() With {.CATEGORY_ID = "0001",
                                     .CATEGORY = "焼肉",
                                     .DEL_FLG = "0"},
            New MST_CATEGORY() With {.CATEGORY_ID = "0002",
                                     .CATEGORY = "海鮮",
                                     .DEL_FLG = "0"}
        }

        MST_CATEGORYs.ForEach(Function(b) context.MST_CATEGORYs.Add(b))
        context.SaveChanges()
    End Sub
End Class
