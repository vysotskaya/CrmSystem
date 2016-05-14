var app = angular.module('crmApp', ['ngResource', 'ui.router', 'highcharts-ng'])
    .config([
        '$stateProvider', '$urlRouterProvider', function ($stateProvider, $urlRouterProvider) {
            $urlRouterProvider.otherwise('/main');
            $stateProvider
                .state('main', {
                    url: '/main',
                    templateUrl: '/Partials/Main',
                    controller: 'crmCtrl'
                })
                .state('planning', {
                    url: '/planning',
                    templateUrl: '/Partials/Planning',
                    controller: 'crmCtrl'
                })
                .state('clients', {
                    url: '/clients',
                    templateUrl: '/Partials/Clients',
                    controller: 'crmCtrl'
                })
                .state('suppliers', {
                    url: '/suppliers',
                    templateUrl: '/Partials/Suppliers',
                    controller: 'crmCtrl'
                })
                .state('archive', {
                    url: '/archive',
                    templateUrl: '/Partials/Archive',
                    controller: 'crmCtrl'
                })
                .state('products', {
                    url: '/products',
                    templateUrl: '/Partials/Products',
                    controller: 'crmCtrl'
                });
        }
    ])
    .constant('CONSTANTS', {
        'URL': 'http://localhost:54510'
    });