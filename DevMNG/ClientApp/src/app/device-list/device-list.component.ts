import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Device } from '../_models/device.model';
import { DeviceService } from '../_services/device.service';

@Component({
  selector: 'app-device-list',
  templateUrl: './device-list.component.html',
  styleUrls: ['./device-list.component.css']
})
export class DeviceListComponent implements OnInit {
  devices: Device[] = [];

  constructor(private router: Router,
    private route: ActivatedRoute, public deviceService: DeviceService) { }

  ngOnInit(): void {
    this.loadDevices();
  }

  onAdd(){
    this.router.navigate(['new'], {relativeTo: this.route});
  }

  loadDevices(){
    this.deviceService.getAllDevices().subscribe(resp => {
      this.devices = resp;
    });
  }

}

