import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DeviceEditComponent } from './device-edit/device-edit.component';
import { DeviceInfoComponent } from './device-info/device-info.component';
import { DeviceListComponent } from './device-list/device-list.component';
import { DeviceNewComponent } from './device-new/device-new.component';
import { DeviceRestartComponent } from './device-restart/device-restart.component';

const routes: Routes = [
  {
    path: '', component: DeviceRestartComponent},
  { path: 'info', component: DeviceInfoComponent },
  { path: 'edit', component: DeviceEditComponent },
  { path: 'new', component: DeviceNewComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
