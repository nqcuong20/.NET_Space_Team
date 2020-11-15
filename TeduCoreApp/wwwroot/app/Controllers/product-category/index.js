﻿var productCategoryController = function () {
    this.initialize = function () {
        loadData();
    }
    //LOAD DỮ LIỆU RA
    function loadData() {
        $.ajax({
            url: '/Admin/ProductCategory/GetAll',//lấy data
            dataType: 'json', //kiểu data
            success: function (response) {
                var data = [];
                $.each(response, function (i, item) {
                    data.push({
                        id: item.Id,
                        text: item.Name,
                        parentId: item.ParentId,
                        sortOrder: item.SortOrder
                    });

                });
                var treeArr = tedu.unflattern(data);

                //var $tree = $('#treeProductCategory');

                $('#treeProductCategory').tree({
                    data: treeArr,
                    dnd: true
                });

            }
        });
    }
}
