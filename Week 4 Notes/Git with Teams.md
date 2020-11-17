# Git with Teams
- Git is a Distributed version control system
    - People can have different versions of things without a unified source
- Git has features that lets you work on multiple cersions of a project at the same time
- With the ability to work on different features at the same time, git also includes features that allow you to communicate any changes you'd want to make to the working version
## Branching
Different branch for any new features you might want to add to the working project
There's the remote branch, in the remote repo, the local branch that can change origins and may not have a remote counterpart, and tracking branches that have a direct relationship to a remote branch.
- git checkout -b &lt;branch name&gt;
    - make a new branch
- git branch &lt;branch name&gt;
    - create new branch without switching
- git checkout &lt;branch name&gt;
    - switch branches
- git push
    - operates on current branch
- git pull origin &lt;branch name&gt;
## Pull Requests
- Don't just push to main
- When you want to merge a completed feature to the main branch, you create a pull request
- With a pull request you are opening any changes you want to commit to main for peer review and comments from other team members
- Any changes you've made on the branch with an open pull request gets added to the pull request
## Merge Conflicts
- What happens when two versions of code are incompatible
    - The code has been edited at the same point by different people
    - This is why we pull often
- When dealing with merge conflicts, have utmost patience, communication is key