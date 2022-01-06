import { createRouter, createWebHistory } from 'vue-router';

const routes = [{
        path: '/',
        name: 'Create New Expense',
        component: () =>
            import ('../components/create-expenses/CreateExpensesComponent'),
    },
    {
        path: '/list-expenses',
        name: 'List All Expenses',
        component: () =>
            import ('../components/list-expenses/ListExpensesComponent'),
    },
    {
        path: '/edit-expenses/:id',
        name: 'Update Expenses',
        component: () =>
            import ('../components/edit-expenses/EditExpensesComponent'),
    },
];

const router = createRouter({
    history: createWebHistory(process.env.BASE_URL),
    routes,
});

export default router;