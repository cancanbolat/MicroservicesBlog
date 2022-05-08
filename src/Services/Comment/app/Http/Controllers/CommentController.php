<?php

namespace App\Http\Controllers;

use App\Repositories\ICommentRepository;
use Illuminate\Http\Request;

class CommentController extends Controller
{
    protected $comment = null;

    public function __construct(ICommentRepository $commentRepo)
    {
        $this->comment = $commentRepo;
    }

    public function GetAll()
    {
        $comments = $this->comment->GetAllComments();
        return response()->json($comments, 200);
    }
}
