# 3D-RougueGame

一个基于Unity和C#的3D肉鸽游戏。

## 1. 准备工作

### 1.1 环境+基本原则

- ✅ **统一使用Unity 2022.3.48** 
- ❌ **禁止操作**：
  直接修改main分支 | 提交Library文件夹 | 删除.meta文件

### 1.2 前置知识

- 学会使用power shell（windows自带终端）操作git指令。
- 学会创建分支，`git pull`、`git push`等命令拉取别人代码、推送自己代码。

实在嫌命令麻烦可以直接用sourcetree、gitgui这种可视化git工具。

### 1.3  克隆仓库

```bash
# 下载仓库
git clone https://github.com/Oakslab-1018/3D-RougueGame.git
# 进入仓库
cd 3D-RougueGame
```

### 1.4 分支策略

我们使用以下分支策略：

- `main`: 稳定版本分支，用于发布。

- `feat/xxx`: 功能开发分支，从 `main` 分支创建，开发完成后合并回 `main`.

## 2. 协作流程

### 2.1 每次开发前

```bash
git checkout main 
git pull #拉取最新的main分支
git checkout -b feature/你的名字缩写  # 例：feature/zs 
```

### 2.2 开发结束后

```powershell
# 1. 检查文件 
git status  # 确认没有多余文件 
 
# 2. 提交代码 
git add .
git commit -m "[功能类型] 做了什么"  # 类型选：角色|场景|数值|特效|音效 
 
# 3. 云端备份 
git push
 
# 4. 把你的分支合并到main（可选，功能完全开发好后再合并）
git merge feature/你的名字缩写 main
```

## 3. 资源管理三原则

### 3.1 文件存放

```
Assets/
├─ Scripts/   # 脚本 
│   └─ 你的名字缩写_功能  # 例：zs_movement 
├─ Art/       # 美术资源 
└─ Prefabs/   # 预制体 
```

### 3.2 命名规范

- 脚本：`角色缩写_功能`（例：`zs_PlayerMove.cs` ）
- 预制体：`P_功能_编号`（例：`P_Enemy_001`）
- 场景：`S_关卡名_日期`（例：`S_Forest_0305`）

## 4. 应对突发状况

### 4.1 防冲突

- 场景文件(.unity)只由一人修改
- 数值表用ScriptableObject分割存储

### 4.2 紧急救援

遇到以下情况停止操作，问ai或者发群里：

1. Unity报错"Missing script"
2. 执行git pull时出现冲突
3. 场景文件显示合并冲突
