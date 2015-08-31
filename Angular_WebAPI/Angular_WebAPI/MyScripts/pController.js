angular.module('app').controller('personInfoController', function ($scope, infoService) {
    
    // Gender List
    $scope.gender = ['Male', 'Female'];
    $scope.selectedGender = 'Male';

    // reset the form
    function initialize() {
        $scope.PersonId = 0;
        $scope.FirstName = "";
        $scope.LastName = "";       
        $scope.selectedGender = 'Male';
        $scope.Age = "";
    }

    $scope.cancelForm = function () {
        initialize();
        console.log('form has been reseted!');
    }

    // submiting the fomr
    $scope.submitForm = function() {
        var Person = {};
        Person.Id = $scope.Id;
        Person.FirstName = $scope.FirstName;
        Person.LastName = $scope.LastName;
        Person.Age = $scope.Age;
        Person.Gender = $scope.selectedGender;


        // send by post via pService
        var sendPost = infoService.postInfo(Person);
        sendPost.then(function(response) {
            console.log(response);
                $scope.PersonId = response.data.Id;
            }, function(err) {
            alert('Some Error Occured');
            }
        );

    }




})