<?php

namespace App\Repositories;

use App\Models\Comment;

class CommentRepository implements ICommentRepository
{
    public function GetAllComments()
    {
        //return Comment::where('postId', 'post-id-2')->get();
        return Comment::all();
    }

    public function AddComment($postId, Comment $comment)
    {
        $newComment = new Comment();

        $newComment->postId = $comment->postId;
        $newComment->email = $comment->email;
        $newComment->name = $comment->name;
        $newComment->content = $comment->content;
        $newComment->content = now();

        $newComment->save();
    }
}
