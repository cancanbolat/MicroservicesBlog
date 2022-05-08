<?php

namespace App\Repositories;

use App\Models\Comment;

interface ICommentRepository
{
    public function GetAllComments();
    public function AddComment($postId, Comment $comment);
}
