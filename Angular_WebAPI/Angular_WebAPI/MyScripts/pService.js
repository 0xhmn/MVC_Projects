// getting api info in this service and passing it to controller
angular.module('app').service('infoService', function ($http) {
    
    this.getInfo = function (id) {
        var req = $http.get('/api/InfoAPI/' + id);
        return req;
    };

    this.getAppInfo = function () {
        var req = $http.get('/api/InfoAPI');
        return req;
    }

    this.postInfo = function (personInfo) {
        var req = $http.post('/api/InfoAPI', personInfo);
        return req;
    };

})