import {Credentials} from '../../models/credentials.interface';
import {authService} from '../../services/auth.service';
import {EventBus} from '../../event-bus';
import {forgotpassword} from'../../models/Forgot.interface';
import {Resetpassword} from '../../models/resetpassword.interface';

const state = { token: localStorage.getItem('auth-token') || '', status: '' };

const getters = {
    isAuthenticated: (authState: any) => !!authState.token,
    authStatus: (authState: any) => authState.status,
    authToken: (authState: any) => authState.token,
};

const actions = {
    authRequest: ({commit, dispatch}: {commit: any, dispatch: any} , credentials: Credentials) => {
        return new Promise((resolve, reject) => {
            commit('authRequest');
            authService.login(credentials)
            .subscribe((result: any) => {
              localStorage.setItem('auth-token', result); // stash the auth token in localStorage
              commit('authSuccess', result);
              EventBus.$emit('logged-in', null);
              dispatch('user/userRequest', null, { root: true });
              resolve(result);
            },
            (errors: any) => {
              commit('authError', errors);
              localStorage.removeItem('auth-token');
              reject(errors);
            });
          });
    },
    forgot:({commit, dispatch}: {commit: any, dispatch: any} , Forgotpassword: forgotpassword) => {
        return new Promise((resolve, reject) => {
            commit('authRequest');
            authService.forgot(Forgotpassword)
            .subscribe((result: any) => {
              localStorage.setItem('auth-token', result); // stash the auth token in localStorage
              commit('authSuccess', result);
              EventBus.$emit('logged-in', null);
              dispatch('user/userRequest', null, { root: true });
              resolve(result);
            },
            (errors: any) => {
              commit('authError', errors);
              localStorage.removeItem('auth-token');
              reject(errors);
            });
          });
    },

    resetpassword:({commit, dispatch}: {commit: any, dispatch: any} , resetpassword: Resetpassword) => {
        return new Promise((resolve, reject) => {
            commit('authRequest');
            authService.reset(resetpassword)
            .subscribe((result: any) => {
              localStorage.setItem('auth-token', result); // stash the auth token in localStorage
              commit('authSuccess', result);
              EventBus.$emit('logged-in', null);
              dispatch('user/userRequest', null, { root: true });
              resolve(result);
            },
            (errors: any) => {
              commit('authError', errors);
              localStorage.removeItem('auth-token');
              reject(errors);
            });
          });
    },

    authLogout: ({commit, dispatch}: {commit: any, dispatch: any}) => {
        return new Promise((resolve, reject) => {
          commit('authLogout');
          localStorage.removeItem('auth-token');
          resolve();
        });
    },
};
const mutations = {
    authRequest: (authState: any) => {
        authState.status = 'attempting authentication request';
    },
    authSuccess: (authState: any, authToken: string) => {
        authState.status = 'authentication succeeded';
        authState.token = authToken;
    },
    authError: (authState: any) => {
        authState.status = 'error';
    },
    authLogout: (authState: any) => {
        authState.token = '';
    },
};

export default {
    state,
    getters,
    actions,
    mutations,
};

