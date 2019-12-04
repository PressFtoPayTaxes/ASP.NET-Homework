import VueRouter from 'vue-router'
import LogIn from './components/LogIn'
import Registration from './components/Registration'
import Posts from './components/Posts'

export default new VueRouter({
    routes: [
        {
            path: '/',
            component: LogIn
        },
        {
            path: '/register',
            component: Registration
        },
        {
            path: '/posts/:id',
            component: Posts,
            name: "posts"
        }
    ]

})