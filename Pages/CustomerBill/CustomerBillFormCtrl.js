app.controller("CustomerBillFormCtrl", function ($scope, $cookieStore, $http, $filter) {
    Clear();
    function Clear() {
        $scope.custoemrBill = {};
        $scope.custoemrBillDetailList = [];

    }
}