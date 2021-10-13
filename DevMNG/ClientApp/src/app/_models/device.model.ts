import { User } from "./user.model";

export interface Device {
    id: string;
    name?: string;
    manufacturer?: string;
    type?: string;
    os?: string;
    osversion?: string;
    processor?: string;
    ram?: string;
    user: User;
}