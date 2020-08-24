"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var UserDataService = /** @class */ (function () {
    function UserDataService(http) {
        this.http = http;
        this.module = '/api/users';
    }
    UserDataService.prototype.get = function () {
        return this.http.get(this.module);
    };
    return UserDataService;
}());
exports.UserDataService = UserDataService;
//# sourceMappingURL=user.data-service.js.map