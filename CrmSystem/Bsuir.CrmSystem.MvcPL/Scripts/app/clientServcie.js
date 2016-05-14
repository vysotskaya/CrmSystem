angular.module('crmApp')
    .factory('clientService', function ($resource, CONSTANTS) {
        //var storedTrains = [];

        function getAll() {
            var resource = $resource(CONSTANTS.URL + '/api/client', {},
            {
                get: { method: 'GET', isArray: true }
            });
            return resource.get.apply(this, arguments);
        }

        //function setTrains(gotTrains) {
        //    angular.copy(gotTrains, storedTrains);
        //}

        //function getStoredTrains() {
        //    return storedTrains;
        //}

        //function getBusses() {
        //    var resource = $resource(CONSTANTS.URL + '/api/transport/busses', {},
        //    {
        //        get: { method: 'GET', isArray: true }
        //    });
        //    return resource.get.apply(this, arguments);
        //}

        //function getDiagramData() {
        //    var resource = $resource(CONSTANTS.URL + '/api/transport/diagram', {},
        //    {
        //        get: { method: 'GET', isArray: true }
        //    });
        //    return resource.get.apply(this, arguments);
        //}

        //function reserveTicket(trainId, count) {
        //    var resource = $resource(CONSTANTS.URL + '/api/transport/ticket?trainId=' + trainId + '&count=' + count, {},
        //    {
        //        save: {
        //            method: 'GET',
        //            isArray: false
        //        }
        //    });
        //    return resource.save.apply(this, arguments);
        //}

        return {
            getAll: getAll
        }
    });