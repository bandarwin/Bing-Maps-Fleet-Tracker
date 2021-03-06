import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';

export enum EnvironmentSettings {
    backendUrl,
    frontendUrl
}

@Injectable()
export class EnvironmentSettingsService {
    getEnvironmentVariable(key: EnvironmentSettings) {
        return environment[EnvironmentSettings[key]];
    }
}
