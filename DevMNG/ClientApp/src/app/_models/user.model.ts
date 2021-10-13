import { Device } from "./device.model";

export interface User {
    id: string;
    name?: string;
    role?: string;
    location?: string;
    device: Device;
}