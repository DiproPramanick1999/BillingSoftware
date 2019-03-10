var vm;
$(document).ready(function () {
   
    vm = new inserting();
    ko.applyBindings(vm);
});


function inserting() {
    var self = this;
    alert("hello");
    self.name = ko.observable('');
    self.product = ko.observable('');
    self.order = ko.observable('');
    self.price = ko.observable('');
    self.send = function () {
        $.ajax({
            type: 'POST',
            url: "insert.aspx/inserts",
            data: "{'id': '" + self.order() + "', 'item': '" + self.product() + "', 'cost': '" + self.price() +"'}",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (msg) {
                self.product('');
                self.order('');
                self.price('');
            },
            error: function (msg) {
                alert("error");
            }
        });
    };
};

