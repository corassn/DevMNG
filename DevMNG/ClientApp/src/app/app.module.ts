import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './header/header.component';
import { DeviceListComponent } from './device-list/device-list.component';
import { DeviceInfoComponent } from './device-info/device-info.component';
import { DeviceEditComponent } from './device-edit/device-edit.component';
import { DeviceNewComponent } from './device-new/device-new.component';
import { DeviceRestartComponent } from './device-restart/device-restart.component';
import { DeviceItemComponent } from './device-list/device-item/device-item.component';


@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    DeviceListComponent,
    DeviceInfoComponent,
    DeviceEditComponent,
    DeviceNewComponent,
    DeviceRestartComponent,
    DeviceItemComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
