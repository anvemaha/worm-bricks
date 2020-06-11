# Game
Educational project. Please see [concept.svg](https://raw.githubusercontent.com/anvemaha/worm-bricks/master/concept.svg) to understand the project.
- Grid
    - Like in Tetris, maybe wider.
    - Full horizontal rows explode, increasing score.
    - Fruits spawn on the grid.
- Worms
    - Pop on the upper half of the grid from the background.
    - Fall like bricks in Tetris once fully on the field.
    - Controlled like snake in the snake game.
    - Grow longer by eating fruits.
- Ghosts
    - Controlled by players that can move freely.
    - Can control worms by posessing them
    - Can move freely
    - Can't eat fruits
    - Multiple players? Co-op? Versus mode?
# Issues
- Nearly 100% GPU utilization (at least on development builds) even with a GTX 1080 unless limited with other software like [RTSS](https://www.guru3d.com/files-details/rtss-rivatuner-statistics-server-download.html).
# Tools
- Visual Studio 2019
- C# + [Otter](http://otter2d.com/)
- [ComTest](https://trac.cc.jyu.fi/projects/comtest/wiki/ComTestInEnglish) 