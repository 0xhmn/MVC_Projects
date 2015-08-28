angular.module('QuizApp', [])
.controller('QuizCtrl', function($scope, $http) {
    $scope.answered = false;
    $scope.title = "loading question...";
    $scope.options = [];
    $scope.correctAnswer = false;
    $scope.working = false;
    

    $scope.answer = function () {
        return $scope.correctAnswer ? 'correct' : 'incorrect';
    };


    // using the api get route
    $scope.nextQuestion = function () {
        console.log('this is a test from console');
        $scope.working = true;
        $scope.answered = false;
        $scope.title = "loading question...";
        $scope.options = [];
        $http.get('/api/trivia').success(function(data, status, headers, config) {
            $scope.options = data.options;
            $scope.title = data.title;
            $scope.answered = false;
            $scope.working = false;
        }).error(function(data, status, headers, config) {
            $scope.title = "oops ... here's an error!";
            $scope.working = false;
        });
    }

    // sending the answer
    $scope.sendAnswer = function (option) {
        console.log("question has been sent");
        $scope.working = true;
        $scope.answered = true;

        $http.post('/api/trivia', { 'questionId': option.questionId, 'optionId': option.id }).success(function (data, status, headers, config) {
            $scope.correctAnswer = (data === "true");
            $scope.working = false;
        }).error(function (data, status, headers, config) {
            $scope.title = "Oops... something went wrong";
            $scope.working = false;
        });
    };

})