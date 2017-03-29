namespace TheNicestWebApp.Controllers {

    export class HomeController {

    }

    export class SecretController {
        public secrets;

        constructor($http: ng.IHttpService) {
            $http.get('/api/secrets').then((results) => {
                this.secrets = results.data;
            });
        }
    }


    export class AboutController {
        public message = 'Web developer who enjoys making websites that are from the more simplistic to the more advanced programs.';
    }

    export class SignUpController {
        public message = "Well you made it to the sign up page."
        public person;
        public persons;

        public personResource;

        public getPerson() {
            this.persons = this.personResource.query();
        }

        public save() {
            this.personResource.save(this.person).$promise.then(() => {
                this.person = null;
                this.getPerson();
            });
        }
        constructor(private $resource: angular.resource.IResourceService) {
            this.personResource = $resource('/api/signup/:id');
            this.getPerson();
        }

    }
}