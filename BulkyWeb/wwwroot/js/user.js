﻿var dataTable;
$(document).ready(function () {
    loadDataTable()
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/admin/user/getall' },
        "columns":
        [
                { data: 'name', "width": "25%" },
                { data: 'email', "width": "15%" },
                { data: 'phoneNumber', "width": "15%" },
                { data: 'company.name', "width": "10%" },               
                { data: 'role', "width": "10%" },
                {
                    data: 'id',
                    'render': function (data) {
                        return `<div class="w-75 btn-group" role="group">
                        <a href="/admin/user/upsert?Id=${data}" class="btn btn-outline-dark mx-2"><i class="bi bi-pencil"></i> Edit</a>                                              
                        </div>`
                    },
                    "width": "25%"
                }
        ]

    });   
}
