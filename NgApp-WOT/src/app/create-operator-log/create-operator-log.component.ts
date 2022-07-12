import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { LocalDataService } from '../services/local-data.service';
import { UserService } from '../services/user.service';
import { DataService } from '../services/data.service';

@Component({
  selector: 'app-create-operator-log',
  templateUrl: './create-operator-log.component.html',
  styleUrls: ['./create-operator-log.component.css']
})
export class CreateOperatorLogComponent implements OnInit {

  operationStatusCollection: Array<any>;
  workOrders: Array<any>;
  operations: Array<any>;

  oprLogForm: FormGroup;
  submitted = false;
  oprLogModel = {
    workOrderId: 0,
    operationNumber: 0,
    operationStatus: 0,
    opStartRunTime: new Date(),
    opPauseRunTime: new Date(),
    opQtyDone: 0,
  };

  apiResponse = '';  
  responseColor = '';
  modelErrors = [];

  constructor( private formBuilder: FormBuilder,
    public userService: UserService,
    public router: Router,
    public localDataService: LocalDataService,
    public dataService: DataService,
    private fb: FormBuilder,) { }

  ngOnInit(): void {
    if (!(this.userService.isLoggedIn && !this.userService.isAdmin)) {
      this.router.navigate(['/home']);
    }   

    this.oprLogForm = this.fb.group({
      WorkOrderId: ['', Validators.required],
      OperationNumber: ['', Validators.required],
      OperationStatus: ['', [Validators.required]],      
      OpStartRunTime: [''],
      OpPauseRunTime: [''],
      OpQtyDone: ['', [Validators.pattern("^[0-9]*$")]],   
    });   
    this.operationStatusCollection = this.localDataService.getOperationStatusToDisplay();
    this.getWorkOrderList();
  }

  getWorkOrderList() {
    this.dataService.getWorkOrderList()
      .subscribe(
        data => {
          this.workOrders = data;
        },
        error => {
          console.log(error);
        }
      );
   }
  
  get oprLogFormControl() {
    return this.oprLogForm.controls;
  }

  resetOprLog() {    
    this.oprLogForm.reset();
    this.submitted = false;
  } 

  goBack() {
    this.router.navigate(['/home']);
  }

  checkForNumbersOnly(newVal) {
    const re = /^\d*\.?\d*$/;
    if (re.test(newVal))
      // console.log('ok');
      return true;
    else
      // console.log('Only Numbers Allowed !!!');
      return false;
  }

  onSubmit(): void {

    this.submitted = true;
    
    if (this.oprLogForm.valid) {
      console.log('form valid!');
    }
    else {
      console.log('form in-valid!');
    }
    
  } 
}
