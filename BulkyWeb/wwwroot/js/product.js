﻿
$(document).ready(function () {
    loadDataTable()
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/admin/product/getall' },
        "columns":
        [
                { data: 'title', "width" : "25%" },
                { data: 'isbn', "width": "15%" },
                { data: 'listPrice', "width": "10%" },
                { data: 'author', "width": "15%" },
                { data: 'category.name', "width": "10%" },
                {
                    data: 'id',
                    'render': function (data) {
                        return `<div class="w-75 btn-group" role="group">
                        <a href="/admin/product/upsert?id=${data}" class="btn btn-outline-dark mx-2"><i class="bi bi-pencil"></i> Edit</a>
                        <a class="btn btn-outline-danger mx-2"><i class="bi bi-trash"></i> Delete</a>
                        
                        </div>`
                    },
                    "width": "25%"
                }
            ]
    });
}

