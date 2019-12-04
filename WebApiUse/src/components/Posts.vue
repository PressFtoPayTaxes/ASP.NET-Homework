<template>
    <div>
        <form>
            <legend><h3>Add Your Post</h3></legend>
            <textarea placeholder="Description" v-model='description'></textarea>
            <br>
            <input type="text" placeholder="Image URL" v-model="imageSource">
            <br>
            <button @click="post">Post</button>
        </form>
        <hr>
        <div class="posts">
            <div class='post' v-for="post in posts" :key='post.Id'>
                <img :src='post.ImageSource'>
                <div class='description'>
                    <b>{{ post.AuthorName }}</b>
                    <p>{{ post.Description }}</p>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
export default {
    data(){
        return {
            description: '',
            imageSource: '',
            posts: []
        }
    },
    methods: {
        post(){
            var post = {
                description: this.description,
                imageSource: this.imageSource,
                user: this.$route.params.id
            };
            this.$http.post('posts', post).then(response => {
                console.log(response);
                this.loadPosts();
            });

        },
        loadPosts(){
            this.$http.get('posts').then(response => {
                console.log(response);
                this.posts = response.data;
                // for(var i = 0; i < response.data; i++){
                //     $('.posts').append($(`<div class='post'>
                //                             <img src='${response.data[i].ImageSource}'>
                //                             <div class='description'>
                //                                 <b>${response.data[i].Author}</b>
                //                                 <p>${response.data[i].Description}</p>
                //                             </div>   
                //                           </div>`));
                // }          
            });
        }
    },
    mounted(){
        this.loadPosts();
    }
}
</script>

<style>
    .posts{
        display: flex;
    }
    .post{
        margin: 15px;
    }
    img{
        width: 300px;
    }
    .description{
        width: 300px;
        height: 40px;
        padding: 10px;
        text-align: left;
        border: 1px solid black;
    }

</style>