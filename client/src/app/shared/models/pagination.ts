export type Paginatiion<T> = {
    pageIndex: number;
    pageSize: number;
    count: number;
    data: T[];
}