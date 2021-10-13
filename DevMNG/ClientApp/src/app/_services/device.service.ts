import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Device } from '../_models/device.model';

@Injectable({
  providedIn: 'root'
})
export class DeviceService {
  baseUrl = 'https://localhost:44367/api/';
  devices: any;

  constructor(private http: HttpClient) { }

  getAllDevices() {
    return this.http.get<Device[]>(this.baseUrl + 'devices');
  }
}
