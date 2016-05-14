angular.module('crmApp')
    .controller('crmCtrl', function ($scope, $state, clientService) {

        $scope.getMainInfo = function () {
            //transportService.getBusses(function (response) {
            //    $scope.busses = response;
            //    $state.go('busses');
            //});
            $state.go('busses');
        };

        $scope.getPlanningInfo = function () {
            //transportService.getBusses(function (response) {
            //    $scope.busses = response;
            //    $state.go('busses');
            //});
            $state.go('planning');
        };

        $scope.getClientsInfo = function () {
            clientService.getAll(function (response) {
                $scope.clients = response;
                $state.go('clients');
            });
        };

        $scope.getSuppliersInfo = function () {
            //transportService.getBusses(function (response) {
            //    $scope.busses = response;
            //    $state.go('busses');
            //});
            $state.go('suppliers');
        };

        $scope.getArchiveInfo = function () {
            //transportService.getBusses(function (response) {
            //    $scope.busses = response;
            //    $state.go('busses');
            //});
            $state.go('archive');
        };

        $scope.getProductsInfo = function () {
            //transportService.getBusses(function (response) {
            //    $scope.busses = response;
            //    $state.go('busses');
            //});
            $state.go('products');
        };

        var diagramData = [];

        //$scope.getDiagram = function () {
        //    transportService.getDiagramData(function (response) {
        //        diagramData = response;
        //        var data = [
        //            ['Vitebsk', diagramData[0]],
        //            ['Mogilev', diagramData[1]],
        //            ['Gomel', diagramData[2]],
        //            ['Brest', diagramData[3]],
        //            ['Grodno', diagramData[4]]
        //        ];

        //        $scope.chartsConfgig = {
        //            options: {
        //                chart: {
        //                    type: 'pie'
        //                },
        //                tooltip: {
        //                    pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>'
        //                },
        //                plotOptions: {
        //                    pie: {
        //                        allowPointSelect: true,
        //                        cursor: 'pointer',
        //                        dataLabels: {
        //                            enabled: false
        //                        },
        //                        showInLegend: true
        //                    }
        //                },
        //                legend: {
        //                    enabled: true
        //                }
        //            },
        //            series: [{
        //                name: 'Brands',
        //                colorByPoint: true,
        //                data: data
        //            }],
        //            title: {
        //                text: 'Transport to regional cities from Minsk'
        //            },
        //            loading: false
        //        }

        //    });

        //};

        //$scope.getDiagram();

        //$scope.getTrains = function () {
        //    transportService.getTrains(function (response) {
        //        $scope.trains = response;
        //        transportService.setTrains($scope.trains);
        //        $state.go('trains');
        //    });
        //};

        //$scope.reserve = function () {
        //    transportService.getTrains(function (response) {
        //        $scope.trains = response;
        //        transportService.setTrains($scope.trains);
        //        $state.go('ticket');
        //    });
        //};

        //$scope.reserveTicket = function (trainId, count) {
        //    transportService.reserveTicket(trainId, count, function (response) {
        //        $scope.count = "";
        //    });
        //}

        //$scope.searchByDest = function (from, to) {
        //    $scope.fromFilter = from;
        //    $scope.toFilter = to;
        //}

        //$scope.canselSearch = function () {
        //    $scope.fromFilter = "";
        //    $scope.toFilter = "";
        //    $scope.from = "";
        //    $scope.to = "";
        //}

        //$scope.getBusses = function () {
        //    transportService.getBusses(function (response) {
        //        $scope.busses = response;
        //        $state.go('busses');
        //    });
        //};

        //$scope.update = function (number) {
        //    $scope.ticket = number;
        //}
    });