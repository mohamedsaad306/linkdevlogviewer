"use strict";
// relatedness items
const constBirds = [{
        id: 1,
        cage: "C02",
        sex: "female",
        metalRing: "F 0111",
        availableMales: [3],
        notAvailableMales: [4]
    },
    {
        id: 2,
        cage: "C02",
        sex: "female",
        metalRing: "F 0122",
        availableMales: [3, 4],
        notAvailableMales: []
    },
    {
        id: 3,
        cage: "C03",
        sex: "male",
        metalRing: "M 0133",
        males: [],
        availableFemales: [1, 2],
        notAvailableFemales: []
    },
    {
        id: 4,
        cage: "C03",
        sex: "male",
        metalRing: "M 0144",
        availableFemales: [2],
        notAvailableFemales: [1]
    }
];
// breeder list items
const constListItmes = [{
        id: 1,
        cage: "C02",
        sex: "female",
        metalRing: "F 0111",
        availableMales: [3],
        notAvailableMales: [4],
        isLayer: true,
        flock: "2017",
        mother: "",
        father: "Unknown",
        status: "Breeders",
        outOn: "2/12/2019",
        deadOn: "",
        source: "Breeding",
        age: {
            days: 17,
            monthes: 3,
            years: 2
        }
    },
    {
        id: 2,
        cage: "C02",
        sex: "female",
        metalRing: "F 0122",
        availableMales: [3, 4],
        notAvailableMales: [],
        isLayer: true,
        flock: "2017",
        mother: "Unknown",
        father: "",
        status: "Breeders",
        outOn: "2/16/2018",
        deadOn: "",
        source: "Breeding",
        age: {
            days: 22,
            monthes: 0,
            years: 1
        }
    },
    {
        id: 3,
        cage: "C03",
        sex: "male",
        metalRing: "M 0133",
        males: [],
        availableFemales: [1, 2],
        notAvailableFemales: [],
        isLayer: false,
        flock: "2017",
        mother: "",
        father: "Unknown",
        status: "Breeders",
        outOn: "",
        deadOn: "",
        source: "",
        age: {
            days: 24,
            monthes: 1,
            years: 3
        }
    },
    {
        id: 4,
        cage: "C03",
        sex: "male",
        metalRing: "M 0144",
        availableFemales: [2],
        notAvailableFemales: [1],
        isLayer: true,
        flock: "2018",
        mother: "F 0321",
        father: "M 0123",
        status: "",
        outOn: "6/1/2020",
        deadOn: "",
        source: "Center Product",
        birthOn: "6/1/2020",
        age: {
            days: 5,
            monthes: 9,
            years: 1
        }
    }
];
const constFlocks = ["2015", "2016", "2017", "2018"];
const constStatisticsByFlockAgeAndSex = [{
        flock: "2015",
        age: "12",
        total: 12,
        malesCount: 4,
        femalesCount: 8
    },
    {
        flock: "2016",
        age: "10",
        total: 20,
        malesCount: 5,
        femalesCount: 15
    },
    {
        flock: "2017",
        age: "9",
        total: 55,
        malesCount: 15,
        femalesCount: 40
    },
    {
        flock: "2018",
        age: "13",
        total: 67,
        malesCount: 12,
        femalesCount: 55
    }
];
const constBirdsAvailableForMovement = [{
        id: 1,
        metalRing: "F 0111",
        cage: "C-1",
        type: "chick",
        sex: "female"
    },
    {
        id: 2,
        metalRing: "F 0122",
        cage: "C-1",
        type: "chick",
        sex: "female"
    },
    {
        id: 3,
        metalRing: "F 0133",
        cage: "C-2",
        type: "chick",
        sex: "female"
    },
    {
        id: 4,
        metalRing: "M 0211",
        cage: "C-1",
        type: "chick",
        sex: "male"
    },
    {
        id: 5,
        metalRing: "M 0222",
        cage: "C-1",
        type: "chick",
        sex: "male"
    },
    {
        id: 6,
        metalRing: "M 0233",
        cage: "C-2",
        type: "chick",
        sex: "male"
    },
    {
        id: 7,
        metalRing: "JF 0311",
        cage: "JC-1",
        type: "Juvenile",
        sex: "female"
    },
    {
        id: 8,
        metalRing: "JF 0322",
        cage: "JC-1",
        type: "Juvenile",
        sex: "female"
    },
    {
        id: 9,
        metalRing: "JF 0333",
        cage: "JC-2",
        type: "Juvenile",
        sex: "female"
    },
    {
        id: 10,
        metalRing: "JM 0411",
        cage: "JC-1",
        type: "Juvenile",
        sex: "male"
    },
    {
        id: 11,
        metalRing: "JM 0422",
        cage: "JC-1",
        type: "Juvenile",
        sex: "male"
    },
    {
        id: 12,
        metalRing: "JM 0433",
        cage: "JC-2",
        type: "Juvenile",
        sex: "male"
    }
];
const constCagesListOptions = [{
        text: "C-1",
        value: 1
    },
    "C-2", "C-3", "JC-1", "JC-2", "JC-3"
];
const constBirdsTypesOptions = ["Juvenile", "chick", "meskof "];
const constSexOptions = ["male", "female"];

const constSemenCollectionHistory = [{
        "collectionRef": "COL-123",
        "collectionDate": "11/02/2019",
        "cage": "C-1",
        "male": "M-0122",
        "isMixed": false,
        "collector": "Dr. John doe",
        "isMissed": false,
        "isContaminated": true,
        "isLowDose": false,
        "semenVolume": 1.5,
        "diluantVolume": 0.5,
        "nbSperm": 0.0,
        "addDiluantVol": 0.5,
        "isUsed": false
    },
    {
        "collectionRef": "COL-1255",
        "collectionDate": "11/02/2019",
        "cage": "C-2",
        "male": "M-0125",
        "isMixed": true,
        "collector": "Dr. John doe",
        "isMissed": true,
        "isContaminated": false,
        "isLowDose": true,
        "semenVolume": 2.3,
        "diluantVolume": 1.4,
        "nbSperm": 0.75,
        "addDiluantVol": 1.5,
        "isUsed": true
    }
]
const constMalesOptionsForNewCollection = [{
        value: 1,
        text: 'M - 1111',
        cage: 'C-1'
    },
    {
        value: 2,
        text: 'M - 1222',
        cage: 'C-2'
    },
]


var relatedness = new Vue({
    el: "#relatedness",
    data: function () {
        return {
            genders: [{
                    text: "Males  Breeder",
                    value: "male"
                },
                {
                    text: "Females  Breeder",
                    value: "female"
                }
            ],
            mainSelectedBirds: [],
            relatedSelectedBirdsList: [],
            cages: [{
                name: "C01"
            }],
            mainSelectedGender: "null",
            maleMainFields: [
                "cage",
                "metalRing",
                {
                    availableFemales: {
                        lable: "label",
                        key: "availableFemales.length"
                    }
                },
                "notAvailableFemales.length"
            ],
            femaleMainFields: [
                "cage",
                "metalRing",
                "availableMales.length",
                "notAvailableMales.length"
            ],
            selectedBird: null,
            selectedBirdRing: "",
            selectedBirdCage: "",
            availability: "",
            relatedFields: ["cage", "metalRing"]
        };
    },
    watch: {
        mainSelectedGender: function () {
            this.mainSelectedBirds = [];
            this.mainSelectedBirds = this.getActiveBirdsList();
        },
        selectedBird: function () {
            if (this.selectedBird) {
                this.selectedBirdRing = this.selectedBird.metalRing;
                this.selectedBirdCage = this.selectedBird.cage;
            } else {
                this.selectedBirdRing = "";
                this.selectedBirdCage = "";
            }
            this.relatedSelectedBirdsList = this.getRelatedBirdsList();

            //mainSelectionRowClick
        }
    },
    computed: {
        mainFields: function () {
            if (this.mainSelectedGender == "male") return this.maleMainFields;
            else return this.femaleMainFields;
        }
    },
    methods: {
        mainSelectionRowClick: function (args) {
            // this.selectedBirdRing = args.metalRing;
            // this.selectedBirdCage = args.cage;
            this.selectedBird = constBirds.slice().find(b => b.id == args.id);

            this.mainSelectedBirds.forEach(element => {
                element._rowVariant = "";
            });
            args._rowVariant = "warning";
            if (args.sex == "female") {
                //  console.log('avaiable males', args.availableMales)
            } else {
                //console.log('available females ', args.availableFemales)
            }
        },
        relatedSelectionRowClick: function (argss) {
            console.log("relted clicked ");
        },
        onChangeBreederType() {
            this.selectedBird = null;
            //  this.mainSelectedBirds = [];

            // this.mainSelectedBirds.forEach(element => {
            //     element._rowVariant = ''
            // });
            console.log(
                "breeder type chnge  mainSelectedBirds:",
                this.mainSelectedBirds
            );
        },
        getActiveBirdsList: function () {
            this.mainSelectedBirds = [];
            let birds = constBirds.filter(b => b.sex == this.mainSelectedGender);
            birds.forEach(b => (b._rowVariant = ""));
            //console.log(birds)
            return birds;
        },

        getRelatedBirdsList: function () {
            let result = [];
            console.log("currently selected ", this.selectedBird);
            if (this.selectedBird) {
                let tt =
                    this.selectedBird.sex == "female" ?
                    this.selectedBird.availableMales.map(m => m) :
                    this.selectedBird.availableFemales.map(m => m);
                result = constBirds.slice().filter(b => tt.indexOf(b.id) > -1);
                result.forEach(b => (b._rowVariant = ""));
                console.log("tt", tt);
            }
            return result;
        }
    }
});
var breederList = new Vue({
    el: "#breederList",
    data: function () {
        return {
            mainBreederList: constListItmes,
            fields: [{
                    key: "isLayer",
                    label: "Layer ",
                    sortable: false
                },
                {
                    key: "metalRing",
                    label: "Metal Ring",
                    sortable: true
                },
                {
                    key: "cage",
                    label: "Cage ",
                    sortable: true
                },
                {
                    key: "sex",
                    label: "Sex",
                    sortable: false
                },
                {
                    key: "birthOn",
                    label: "Birth On ",
                    sortable: true
                },
                {
                    key: "age",
                    label: "Age",
                    sortable: false
                },
                {
                    key: "status",
                    label: "Status",
                    sortable: false
                },
                {
                    key: "mother",
                    label: "Mother",
                    sortable: false
                },
                {
                    key: "father",
                    label: "Father",
                    sortable: false
                },
                {
                    key: "deadOn",
                    label: "Died On",
                    sortable: true
                },
                {
                    key: "outOn",
                    label: "Release On",
                    sortable: true
                },
                {
                    key: "source",
                    label: "Source",
                    sortable: false
                }
            ],
            currentPage: 1,
            perPage: 100,
            filter: null,
            sortBy: null,
            sortDesc: false,
            sortDirection: "asc",
            pageOptions: [1, 2, 5],
            totalRows: constListItmes.length,
            perSex: null,
            perFlock: null,
            sexOptions: ["female", "male"]
        };
    },
    watch: {
        perSex: function () {
            this.mainBreederList = this.applyFilter();
        },
        perFlock: function () {
            this.mainBreederList = this.applyFilter();
        }
    },
    computed: {
        sortOptions() {
            // Create an options list from our fields
            return this.fields
                .filter(f => f.sortable)
                .map(f => {
                    return {
                        text: f.label,
                        value: f.key
                    };
                });
        },
        flocksOptions() {
            // return this.mainBreederList.map(f=>{return {text:f.flock , value:f.flock}});
            return ["2015", "2016", "2017", "2018"];
        }
    },
    methods: {
        onFiltered: function (filteredItems) {
            this.totalRows = filteredItems.length;
            this.currentPage = 1;
        },
        applyFilter: function () {
            let result = constListItmes;

            if (this.perSex) {
                result = result.filter(b => b.sex == this.perSex);
            }
            if (this.perFlock) {
                result = result.filter(b => b.flock == this.perFlock);
            }
            return result;
        }
    }
});

var breederByFlocksAndSex = new Vue({
    el: "#breederByFlocksAndSex",
    data: function () {
        return {
            items: constStatisticsByFlockAgeAndSex,
            flocks: constFlocks
        };
    }
});

var birdsMovement = new Vue({
    el: "#birdsMovement",
    data: function () {
        return {
            birdsAvailableTomove: constBirdsAvailableForMovement,
            cagesListOptions: constCagesListOptions,
            birdsTypesOptions: constBirdsTypesOptions,
            sexOptions: constSexOptions,
            filterByType: null,
            filterByCage: null,
            filterBySex: null,
            availableTableFields: [{
                    _isSelected: {
                        key: "_isSelected",
                        label: "Seleceted"
                    }
                },
                "metalRing",
                "cage",
                "type",
                "sex"
            ],
            selectedBirdsForMovement: [],
            distnationCage: null,
            movementReason: "",
            movementDate: new Date()
        };
    },
    computed: {
        enableConfirm: function () {
            return !(
                this.selectedBirdsForMovement.length > 0 && this.distnationCage != null
            );
        }
    },
    watch: {
        birdsAvailableTomove: function () {
            console.log("(selection changed )", this.birdsAvailableTomove);
        }
    },
    methods: {
        selectItemChanged: function (arg) {
            //console.log('item changed args ', arg)
            arg.item._isSelected = !arg.item._isSelected;

            if (arg.item._isSelected) {
                arg.item._rowVariant = "warning";
                this.selectedBirdsForMovement.push(arg.item);
            } else {
                arg.item._rowVariant = "";
                this.selectedBirdsForMovement = this.selectedBirdsForMovement.filter(
                    e => e.id != arg.item.id
                );
            }
            // console.log('selected for movement ', this.selectedBirdsForMovement)
            // this.$root.$emit('bv::refresh::table', 'tobemoved-table');
        },
        confirmMovemnt: function () {
            console.log("Movement Cofirmed ");
        }
    }
});

var semenCollection = new Vue({
    el: "#semenCollection",
    data: function () {
        return {
            collectionFields: [
                "collectionRef",
                "collectionDate",
                "cage",
                "male",
                "collector",
                "isMixed",
                "isMissed",
                "isContaminated",
                "isLowDose",
                "semenVolume",
                "diluantVolume",
                "nbSperm",
                "addDiluantVol",
                "isUsed"
            ],
            collectionHistoryItems: constSemenCollectionHistory,
            filter: null,
            cagesOptions: constCagesListOptions,
            malesOptions: constMalesOptionsForNewCollection,
            newCollection: {
                date: null,
                Cage: 1,
                Male: 2,
                isMissed: null,
                isContaminated: null,
                isLowDose: null,
            },


        };
    },
    methods: {
        onFiltered: function (filteredItems) {
            //this.totalRows = filteredItems.length;
            this.currentPage = 1;
        },
        createNewColelction: function () {
            console.log('New Semen Collection Ok', this.newCollection)
        }
    }
});

/**
 * todo
 *  * movement com
 *      - list types
 *      - list cages
 *      - list items to be moved according to selected type and cage
 *      - highlight selected
 *      - add check box to display all items  or only types has data (enh)
 *      - Display available counts (enh)
 *      - template move to area (movement table - count (males / females ) )
 *      - invoke movement action
 *      - validate selection before confirm.
 *          (Not done )
 *      - create movement history
 *      - apply source filter 
 *
 *  * new sement collection
 *      -
 *
 */