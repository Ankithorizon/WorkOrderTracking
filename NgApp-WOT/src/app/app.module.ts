import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HttpClient, HTTP_INTERCEPTORS } from '@angular/common/http';

import { NgxNavbarModule } from 'ngx-bootstrap-navbar';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

import { NgxPaginationModule } from 'ngx-pagination';
import { Ng2SearchPipeModule } from 'ng2-search-filter';

import { BsDatepickerModule } from 'ngx-bootstrap/datepicker';

import { GoogleChartsModule } from 'angular-google-charts';


// services
import { DataService } from './services/data.service';
import { UserService } from './services/user.service';
import { LocalDataService } from './services/local-data.service';

// auth
import { AuthGuard } from './auth/auth.guard';
import { AuthInterceptor } from './auth/auth.interceptor';

// components
import { HomeComponent } from './home/home.component';
import { HeaderComponent } from './header/header.component';
import { PartComponent } from './part/part.component';
import { CustomerOrderComponent } from './customer-order/customer-order.component';
import { WorkOrderComponent } from './work-order/work-order.component';
import { OperationComponent } from './operation/operation.component';
import { SigninComponent } from './signin/signin.component';
import { RegistrationComponent } from './registration/registration.component';
import { CreateOperatorLogComponent } from './create-operator-log/create-operator-log.component';
import { ViewOperatorLogComponent } from './view-operator-log/view-operator-log.component';
import { PartCreateComponent } from './part-create/part-create.component';
import { PartEditComponent } from './part-edit/part-edit.component';
import { PartRemoveComponent } from './part-remove/part-remove.component';
import { PartImageUploadComponent } from './part-image-upload/part-image-upload.component';
import { PartUploadComponent } from './part-upload/part-upload.component';
import { CustomerOrderCreateComponent } from './customer-order-create/customer-order-create.component';
import { CustomerOrderEditComponent } from './customer-order-edit/customer-order-edit.component';
import { CustomerOrderRemoveComponent } from './customer-order-remove/customer-order-remove.component';
import { CustomerOrderProgressTextReportComponent } from './customer-order-progress-text-report/customer-order-progress-text-report.component';
import { CustomerOrderReportComponent } from './customer-order-progress-text-report/customer-order-report/customer-order-report.component';
import { WorkOrderReportComponent } from './customer-order-progress-text-report/work-order-report/work-order-report.component';
import { OperationReportComponent } from './customer-order-progress-text-report/operation-report/operation-report.component';
import { OperatorLogReportComponent } from './customer-order-progress-text-report/operator-log-report/operator-log-report.component';
import { CustomerOrderDetailsModalComponent } from './work-order/customer-order-details-modal/customer-order-details-modal.component';
import { WorkOrderCreateComponent } from './work-order-create/work-order-create.component';
import { WorkOrderEditComponent } from './work-order-edit/work-order-edit.component';
import { WorkOrderRemoveComponent } from './work-order-remove/work-order-remove.component';
import { OperationCreateComponent } from './operation-create/operation-create.component';
import { OperationEditComponent } from './operation-edit/operation-edit.component';
import { XferPartsComponent } from './xfer-parts/xfer-parts.component';
import { XferHistoryComponent } from './xfer-history/xfer-history.component';
import { OperationLogComponent } from './operation-log/operation-log.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    HeaderComponent,
    PartComponent,
    CustomerOrderComponent,
    WorkOrderComponent,
    OperationComponent,
    SigninComponent,
    RegistrationComponent,
    CreateOperatorLogComponent,
    ViewOperatorLogComponent,
    PartCreateComponent,
    PartEditComponent,
    PartRemoveComponent,
    PartImageUploadComponent,
    PartUploadComponent,
    CustomerOrderCreateComponent,
    CustomerOrderEditComponent,
    CustomerOrderRemoveComponent,
    CustomerOrderProgressTextReportComponent,
    CustomerOrderReportComponent,
    WorkOrderReportComponent,
    OperationReportComponent,
    OperatorLogReportComponent,
    CustomerOrderDetailsModalComponent,
    WorkOrderCreateComponent,
    WorkOrderEditComponent,
    WorkOrderRemoveComponent,
    OperationCreateComponent,
    OperationEditComponent,
    XferPartsComponent,
    XferHistoryComponent,
    OperationLogComponent
  ],
  imports: [   
    BrowserModule,    
    NgbModule,
    FormsModule,    
    BrowserAnimationsModule,
    ReactiveFormsModule,
    HttpClientModule,
    AppRoutingModule,
    NgxNavbarModule,
    NgxPaginationModule,
    Ng2SearchPipeModule,
    GoogleChartsModule,
    BsDatepickerModule.forRoot(),
  
  ],
  providers: [HttpClientModule, LocalDataService, DataService, UserService, {
    provide: HTTP_INTERCEPTORS,
    useClass: AuthInterceptor,
    multi: true
  },  
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
