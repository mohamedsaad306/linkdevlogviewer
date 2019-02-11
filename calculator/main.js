"use strict";
const constBirds = [{
        id: 1,
        cage: 'C02',
        sex: 'female',
        metalRing: 'F 0111',
        availableMales: [3],
        notAvailableMales: [4]
    },
    {
        id: 2,
        cage: 'C02',
        sex: 'female',
        metalRing: 'F 0122',
        availableMales: [3, 4],
        notAvailableMales: []
    },
    {
        id: 3,
        cage: 'C03',
        sex: 'male',
        metalRing: 'M 0133',
        males: [],
        availableFemales: [1, 2],
        notAvailableFemales: [],
    },
    {
        id: 4,
        cage: 'C03',
        sex: 'male',
        metalRing: 'M 0144',
        availableFemales: [2],
        notAvailableFemales: [1],
    }
];

var transactions = new Vue({
    el: '#transactions',
    data: function () {
        return {
            fields: [
                'index',
                'amount',
                'txt',
                'date'
            ]
        }
    }

});

var breeder = new Vue({
    el: '#breeder',
    data: function () {
        return {
            genders: [{
                text: 'Males  Breeder',
                value: 'male'
            }, {
                text: 'Females  Breeder',
                value: 'female'
            }],
            mainSelectedBirds: [],
            relatedSelectedBirdsList: [],
            cages: [{
                name: 'C01'
            }],
            mainSelectedGender: 'null',
            maleMainFields: ['cage', 'metalRing', {
                'availableFemales': {
                    lable: 'label',
                    key: 'availableFemales.length'
                }
            }, 'notAvailableFemales.length'],
            femaleMainFields: ['cage', 'metalRing', 'availableMales.length', 'notAvailableMales.length'],

            selectedBird: null,
            selectedBirdRing: '',
            selectedBirdCage: '',
            relatedFields: ['cage', 'metalRing']
        }
    },
    watch: {
        mainSelectedGender: function () {
            this.mainSelectedBirds =[];
            this.mainSelectedBirds = this.getActiveBirdsList();
        },
        selectedBird: function () {
            this.relatedSelectedBirdsList = this.getRelatedBirdsList(); 

            //mainSelectionRowClick
        }
    },
    computed: {
        mainFields: function () {
            if (this.mainSelectedGender == 'male')
                return this.maleMainFields;
            else return this.femaleMainFields;
        },
        
    },
    methods: {
        mainSelectionRowClick: function (args) {
            this.selectedBirdRing = args.metalRing;
            this.selectedBirdCage = args.cage;
            this.selectedBird = constBirds.slice().find(b=>b.id== args.id);

            this.mainSelectedBirds.forEach(element => {
                element._rowVariant = ''
            });
            args._rowVariant = 'success';
            if (args.sex == 'female') {
                //  console.log('avaiable males', args.availableMales)
            } else {
                //console.log('available females ', args.availableFemales)
            }
        },
        relatedSelectionRowClick: function (argss) {
            console.log('relted clicked ')
        },
        onChangeBreederType() {
            this.selectedBird = null;
          //  this.mainSelectedBirds = [];

            // this.mainSelectedBirds.forEach(element => {
            //     element._rowVariant = ''
            // });
            console.log('mainSelectedBirds', this.mainSelectedBirds)
        }, 
        getActiveBirdsList: function () {
            this.mainSelectedBirds = [];
            let birds = constBirds.filter(b => b.sex == this.mainSelectedGender);

            console.log(birds)
            return birds;
        },

        getRelatedBirdsList: function () {
            let result = [];
            console.log('currently selected ', this.selectedBird)
            if (this.selectedBird.sex== 'female'){
                console.log('available males ',this.selectedBird.availableMales)
                let tt = this.selectedBird.availableMales.map(m=>m);
                console.log('tt', tt)
            }

            return result;
        }
    }
})

var app = new Vue({
    el: '#app',
    data: function () {
        return {
            title: "app works ",
            amount: "",
            total: 0,
        }
    },
    methods: {

    },
});