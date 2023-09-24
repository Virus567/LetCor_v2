import axios from 'axios';
import {Answer, LoginModel, RegistrationModel} from "../../models/RequestModel";
import {removeCookie, setCookie} from "typescript-cookie";
import {RegisterSuccess, RegisterFail, LoginSuccess, LoginFail, Logout} from "../actions/authActions"
import {User} from "../../models/UserModel";
import {clientActions} from "../slices/clientslice";

const API_URL = "http://localhost:8080/auth/";


class AuthService {
	register(reg: RegistrationModel) {
		return axios.post(API_URL + "signon", reg)
			.then((res) => {
					setCookie("access_token", res.data.accessToken, {expires:365, path: ''});
					const user: User = res.data.user;
					localStorage.setItem('user', JSON.stringify(user))
					return clientActions.registerSuccess({isAuth: true, user: user});
				}
			).catch((err) => {
				return RegisterFail(err);
			})
	}

	login(login: LoginModel) {
		return axios.post(API_URL + "signin", login).then(
			(res) => {
					setCookie("access_token", res.data.accessToken, {expires: 365, path: ''});
					const user: User = res.data.user;
					localStorage.setItem('user', JSON.stringify(user));
					return clientActions.loginSuccess({isAuth: true, user: user});
			}).catch((err) => {
			return LoginFail(err);
		})
	}
	logout(){
		removeCookie("access_token", {path: ''});
		localStorage.removeItem('user');
		return clientActions.logout();
	}
}
export default new AuthService();