var mainVM;
$(document).ready(function () {
    mainVM = new loginViewModel();
    ko.applyBindings(mainVM);
});
function NameListViewModel(CP, NL) {

    var self = this;
    self.orderId = ko.observable();
    self.product = ko.observable();
    self.price = ko.observable();
    this.id = ko.observable();
    if (CP) {
        self.product(CP.data.item);
        self.orderId(CP.data.id);
        self.price(CP.data.cost);
        this.id(CP.data.id);
    };
    self.cdelete = function () {
        $.ajax({
            type: "POST",
            url: "admin.aspx/deleteName",
            data: "{'id':'" + this.id() + "'}",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function () {
                location.reload();


            },
            error: function () {
                alert("Error")
            }
        });
    };

    /* self.cedit = function () {
          window.location = "modifyName.aspx?id=" + this.id();
      };*/
};


function loginViewModel() {

    var self = this;
    self.productList = ko.observableArray([]);
    $.ajax({
        type: "POST",
        url: "admin.aspx/getProducts",
        data: "{}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (datas) {
            for (var i = 0; i < datas.d.length; i++) {
                self.productList.push(new NameListViewModel({ data: datas.d[i] }));
            };
        },
        error: function () {
            alert("Error")
        }
    });
};

function Inserting() {

    var self = this;
    self.order = ko.observable('');
    self.product = ko.observable('');
    self.price = ko.observable('');
    self.send = function () {
        $.ajax({
            type: "POST",
            url: "admin.aspx/inserts",
            data: "{'cost':'" + self.price() + "'}",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function () {
                self.price('');
                location.reload();

            },
            error: function () {
                alert("error");
            }
        });
    };
};


